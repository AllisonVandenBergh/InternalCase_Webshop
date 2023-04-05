import { Button } from "@/components/Button";
import { AiOutlineShoppingCart } from "react-icons/ai";

export const NavigationBasket = () => {
  // At this moment hardcoded, will be changed.
  const amountItems = 8;
  const subtotal = 999;

  return (
    <div className="dropdown dropdown-end">
      <Button className="mr-4" rounded variant="ghost">
        <div className="indicator">
          <AiOutlineShoppingCart size="1.5em" />
          <span className="badge badge-sm badge-outline-accent indicator-item text-[#00ff00]">
            {amountItems}
          </span>
        </div>
      </Button>
      <div className="card card-compact dropdown-content w-52 bg-zinc-50 shadow">
        <div className="card-body">
          <span className="font-bold text-lg">{amountItems} Items</span>
          <span>Subtotal: {subtotal}€</span>
          <div className="card-actions">
            <button className="btn btn-primary btn-block">View cart</button>
          </div>
        </div>
      </div>
    </div>
  );
};
