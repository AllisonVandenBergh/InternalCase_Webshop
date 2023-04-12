import Button from "@/components/Button";
import { Product } from "@/models/product";
import { useMutation, useQuery, useQueryClient } from "@tanstack/react-query";
import { AiOutlineEdit, AiOutlineDelete } from "react-icons/ai";
import { HiOutlineCheck } from "react-icons/hi";
import { IoCloseOutline } from "react-icons/io5";
import { toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import { MouseEvent, useState } from "react";
import DeleteModal from "./DeleteModal";
import DetailModal from "./DetailModal";
import { useNavigate } from "react-router-dom";
import { deleteProduct, getAllProducts } from "@/api/product";
import Image from "@/components/Image";
import { FormatCurrency } from "@/utils/Currency";

const ProductsTable = () => {
  const [productToDelete, setProductToDelete] = useState<Product | null>();
  const [product, setProduct] = useState<Product | null>();

  const navigate = useNavigate();

  // const { data } = useQueryProducts({
  //   onError: (_) => {
  //     toast.error("Error fetching the data from the server 🫣");
  //   },
  // });

  const queryClient = useQueryClient();
  const {
    data: products,
    error: fetchProductsError,
    isLoading,
  } = useQuery({
    queryKey: ["products"],
    queryFn: getAllProducts,
    onError: () => {
      toast.error("Error fetching the data from the server 🫣");
    },
  });

  const { mutate: deleteMutation } = useMutation({
    mutationFn: deleteProduct,
    onSuccess: () => {
      queryClient.invalidateQueries({ queryKey: ["products"] });
      toast.success(`'${productToDelete?.name}' is deleted 👌`);
      setProductToDelete(null);
    },
    onError: () => {
      toast.error(`Error deleting '${productToDelete?.name}' 🫣`);
    },
  });

  const handleDeleteButtonClicked = (
    e: MouseEvent<HTMLButtonElement>,
    product: Product
  ) => {
    e.stopPropagation();
    setProductToDelete(product);
  };

  const handleDelete = () => {
    if (!productToDelete?.id) return;

    deleteMutation(productToDelete.id);
  };

  // TODO: provider alternative rendering for error state

  // <DataTable columns={columns} data={data} error={error} />

  if (isLoading) {
    return <>Loading...</>;
  }

  return (
    <div className="overflow-x-auto w-full">
      <table className="table w-full">
        <thead>
          <tr>
            <th></th>
            <th>Name</th>
            <th>Sku</th>
            <th>Base price (€)</th>
            <th>Sell price (€)</th>
            <th>In stock?</th>
            <th></th>
          </tr>
        </thead>
        {!fetchProductsError && (
          <tbody>
            {products?.map((product) => (
              <tr
                key={product.id}
                className="hover cursor-pointer"
                onClick={() => setProduct(product)}
              >
                <td>
                  <Image image={product.image} className="w-24" />
                </td>
                <td>{product.name}</td>
                <td>{product.sku}</td>
                <td>{FormatCurrency(product.basePrice)}</td>
                <td>{FormatCurrency(product.sellPrice)}</td>
                <td>
                  {product.inStock ? (
                    <HiOutlineCheck size={22} />
                  ) : (
                    <IoCloseOutline size={22} />
                  )}
                </td>
                <td className="text-end">
                  <Button
                    rounded
                    variant="ghost"
                    onClick={() => navigate(`/admin/edit/${product.id}`)}
                  >
                    <AiOutlineEdit size={20} />
                  </Button>
                  <Button
                    rounded
                    variant="ghost"
                    onClick={(e) => handleDeleteButtonClicked(e, product)}
                  >
                    <AiOutlineDelete size={20} />
                  </Button>
                </td>
              </tr>
            ))}
          </tbody>
        )}
      </table>

      <DeleteModal
        open={!!productToDelete}
        onCancel={() => setProductToDelete(null)}
        onDelete={handleDelete}
      />

      <DetailModal
        open={!!product}
        onClose={() => setProduct(null)}
        product={product}
      />
    </div>
  );
};

export default ProductsTable;
