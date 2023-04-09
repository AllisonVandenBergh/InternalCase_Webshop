import { Button } from "@/components/Button";
import { Product } from "@/models/product";
import { deleteProduct, getAllProducts } from "@/utils/requests";
import { useMutation, useQuery, useQueryClient } from "@tanstack/react-query";
import { AiOutlineEdit, AiOutlineDelete } from "react-icons/ai";
import { HiDotsVertical, HiOutlineCheck } from "react-icons/hi";
import { IoCloseOutline } from "react-icons/io5";
import { toast } from "react-toastify";
import imageNotFound from "@/assets/imageNotFound.png";
import "react-toastify/dist/ReactToastify.css";
import { useState } from "react";
import { DeleteModal } from "./DeleteModal";
import { DetailModal } from "./DetailModal";
import { useNavigate } from "react-router-dom";

export const ProductsTable = () => {
  const [productToDelete, setProductToDelete] = useState<Product | null>();
  const [product, setProduct] = useState<Product | null>();

  const navigate = useNavigate();

  const queryClient = useQueryClient();
  const {
    data: products,
    error: fetchProductsError,
    isLoading,
  } = useQuery<Product[]>({
    queryKey: ["products"],
    queryFn: getAllProducts,
    onError: (_) => {
      toast.error("Error fetching the data from the server 🫣");
    },
  });

  const deleteElement = useMutation({
    mutationFn: deleteProduct,
    onSuccess: (_) => {
      queryClient.invalidateQueries({ queryKey: ["products"] });
      toast.success(`'${productToDelete?.name}' is deleted 👌`);
      setProductToDelete(null);
    },
    onError: (_) => {
      toast.error(`Error deleting '${productToDelete?.name}' 🫣`);
    },
  });

  const handleDelete = () => {
    if (!productToDelete?.id) return;

    deleteElement?.mutate(productToDelete.id);
  };

  return (
    <div className="overflow-x-auto w-full">
      {isLoading ? (
        <>Loading...</>
      ) : (
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
          {(!fetchProductsError || !deleteElement.error) && (
            <tbody>
              {products?.map((product) => (
                <tr key={product.id} className="hover">
                  <td>
                    <div className="w-24 rounded overflow-hidden">
                      <img
                        src={product.image}
                        onError={({ currentTarget }) => {
                          currentTarget.onerror = null;
                          currentTarget.src = imageNotFound;
                        }}
                      />
                    </div>
                  </td>
                  <td>{product.name}</td>
                  <td>{product.sku}</td>
                  <td>
                    {product.basePrice.toFixed(2).toString().replace(".", ",")}
                  </td>
                  <td>
                    {product.sellPrice.toFixed(2).toString().replace(".", ",")}
                  </td>
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
                      onClick={() => navigate(`/edit/${product.id}`)}
                    >
                      <AiOutlineEdit size={20} />
                    </Button>
                    <Button rounded variant="ghost">
                      <AiOutlineDelete
                        size={20}
                        onClick={() => setProductToDelete(product)}
                      />
                    </Button>
                    <Button
                      rounded
                      variant="ghost"
                      onClick={() => setProduct(product)}
                    >
                      <HiDotsVertical size={20} />
                    </Button>
                  </td>
                </tr>
              ))}
            </tbody>
          )}
        </table>
      )}

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
