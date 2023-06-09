import Modal from "@/components/Modal";
import { Product } from "@/models/product";
import { HiOutlineCheck } from "react-icons/hi";
import { IoCloseOutline } from "react-icons/io5";
import Badge from "@/components/Badge";
import PriceContainer from "./PriceContainer";
import Image from "@/components/Image";

type DetailModalProps = {
  open: boolean;
  onClose: () => void;
  product?: Product | null;
};

const DetailModal = ({ open, onClose, product }: DetailModalProps) => {
  if (!product) return <></>;

  return (
    <Modal
      open={open}
      onCloseButtonClick={onClose}
      className="w-[1000px] max-w-[1500px] h-[350px]"
    >
      <div className="flex w-[95%] divide-x h-full">
        <div className="flex items-center mr-4">
          <Image image={product.image} className="w-[250px]" />
        </div>
        <div className="flex flex-col justify-between pl-5 ">
          <div className="flex-1">
            <h2 className="header">{product.name}</h2>
            <div className="flex justify-between font-medium">
              <p>{product.sku}</p>
              <p className="text-sm">(sku)</p>
            </div>
            <p className="text-sm mt-2">{product.description}</p>
          </div>
          <div className="flex items-center justify-between mt-4">
            <div className="h-24 pr-5 flex justify-center flex-col">
              <PriceContainer price={product.sellPrice} name="sell price" />
              <PriceContainer
                variant="small"
                price={product.basePrice}
                name="base price"
                className="pt-2"
              />
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

export default DetailModal;
