import { Modal } from "@/components/Modal";
import { Header1, Header2 } from "@/components/Typography";
import { Product } from "@/models/product";
import { HiOutlineCheck } from "react-icons/hi";
import { IoCloseOutline } from "react-icons/io5";
import imageNotFound from "@/assets/imageNotFound.png";
import { Badge } from "@/components/Badge";

type DetailModalProps = {
  open: boolean;
  onClose: () => void;
  product?: Product | null;
};

export const DetailModal = ({ open, onClose, product }: DetailModalProps) => {
  if (!product) return <></>;

  return (
    <Modal
      open={open}
      onCloseButtonClick={onClose}
      className="w-[1000px] max-w-[1500px] h-[350px]"
    >
      <div className="flex w-[95%] divide-x h-full">
        <div className="flex items-center mr-4">
          <div className="w-[250px] overflow-hidden rounded-md">
            <img
              src={product.image}
              onError={({ currentTarget }) => {
                currentTarget.onerror = null;
                currentTarget.src = imageNotFound;
              }}
            />
          </div>
        </div>
        <div className="flex flex-col justify-between pl-5 ">
          <div className="flex-1">
            <Header1>{product.name}</Header1>
            <div className="flex justify-between font-medium">
              <p>{product.sku}</p>
              <p className="text-sm">(sku)</p>
            </div>
            <p className="text-sm mt-2">{product.description}</p>
          </div>
          <div className="flex items-center justify-between mt-4">
            <div className="h-24 pr-5 flex justify-center flex-col">
              <div className="flex">
                <p className="text-xs font-medium mr-1">€</p>
                <div className="flex items-end gap-1">
                  <p className="text-lg font-medium">
                    {product.sellPrice.toString().replace(".", ",")}
                  </p>
                  <p className="text-sm pb-[1px] italic">sell price</p>
                </div>
              </div>
              <div className="flex pt-2">
                <p className="text-xs font-medium mr-1">€</p>
                <div className="flex items-end gap-1">
                  <p className="text-sm font-medium">
                    {product.basePrice.toString().replace(".", ",")}
                  </p>
                  <p className="text-xs pb-[1px] italic">base price</p>
                </div>
              </div>
            </div>
            <div className="h-24 pl-10 flex items-center">
              {product.inStock ? (
                <Badge
                  className="border-lime-600 text-lime-600"
                  icon={<HiOutlineCheck size={22} />}
                >
                  IN STOCK
                </Badge>
              ) : (
                <Badge
                  className="border-rose-500 text-rose-500"
                  icon={<IoCloseOutline size={22} />}
                >
                  OUT OF STOCK
                </Badge>
              )}
            </div>
          </div>
        </div>
      </div>
    </Modal>
  );
};
