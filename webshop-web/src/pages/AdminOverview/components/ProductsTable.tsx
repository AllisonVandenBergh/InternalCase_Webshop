import { Button } from "@/components/Button";
import { Product } from "@/models/product";
import { getAllProducts } from "@/utils/requests";
import { useQuery } from "@tanstack/react-query";
import { AiOutlineEdit, AiOutlineDelete } from "react-icons/ai";
import { HiDotsVertical, HiOutlineCheck } from "react-icons/hi";
import { IoCloseOutline } from "react-icons/io5";
import { toast } from "react-toastify";
import imageNotFound from "@/assets/imageNotFound.png";
import "react-toastify/dist/ReactToastify.css";

export const ProductsTable = () => {
  const { data, error, isLoading } = useQuery<Product[], Error>({
    queryKey: ["products"],
    queryFn: getAllProducts,
  });

  if (error) {
    toast.error("Error fetching the data from the server.", {
      toastId: "error1",
    });
  }

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
          {!error && (
            <tbody>
              {data?.map((product) => (
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
                  <td>{product.basePrice.toString().replace(".", ",")}</td>
                  <td>{product.sellPrice.toString().replace(".", ",")}</td>
                  <td>
                    {product.inStock ? (
                      <HiOutlineCheck size={22} />
                    ) : (
                      <IoCloseOutline size={22} />
                    )}
                  </td>
                  <td className="text-end">
                    <Button rounded variant="ghost">
                      <AiOutlineEdit size={20} />
                    </Button>
                    <Button rounded variant="ghost">
                      <AiOutlineDelete size={20} />
                    </Button>
                    <Button rounded variant="ghost">
                      <HiDotsVertical size={20} />
                    </Button>
                  </td>
                </tr>
              ))}
            </tbody>
          )}
        </table>
      )}
    </div>
  );
};
