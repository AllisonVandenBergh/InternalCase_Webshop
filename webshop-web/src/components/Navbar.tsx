import profileImage from "../assets/profileImage.jpeg";
import { HiLogout } from "react-icons/hi";
import { AiOutlineShoppingCart } from "react-icons/ai";

export const Navbar = () => {
  const amountItems = 8;
  const subtotal = 999;

  return (
    <div className="navbar bg-[#fcfcfc]">
      <div className="navbar-start">
        <p className="text-xl mx-2">Euricom Webshop</p>
      </div>
      <div className="navbar-center flex">
        <button className="btn btn-ghost">Admin panel</button>
        <button className="btn btn-ghost">Items list</button>
      </div>
      <div className="navbar-end">
        <div className="dropdown dropdown-end">
          <button className="btn btn-ghost btn-circle">
            <div className="indicator">
              <AiOutlineShoppingCart size="1.5em" />
              <span className="badge badge-sm badge-outline-accent indicator-item text-[#00ff00]">
                {amountItems}
              </span>
            </div>
          </button>
          <div className="mt-3 card card-compact dropdown-content w-52 bg-base-100 shadow">
            <div className="card-body">
              <span className="font-bold text-lg">{amountItems} Items</span>
              <span>Subtotal: {subtotal}€</span>
              <div className="card-actions">
                <button className="btn btn-primary btn-block">View cart</button>
              </div>
            </div>
          </div>
        </div>
        <div className="dropdown dropdown-end">
          <button className="btn btn-ghost btn-circle avatar">
            <div className="rounded-full">
              <img src={profileImage} />
            </div>
          </button>
          <ul className="menu menu-compact dropdown-content mt-3 p-2 shadow-lg bg-base-100 rounded-box w-52">
            <li>
              <a>
                <HiLogout />
                Logout
              </a>
            </li>
          </ul>
        </div>
      </div>
    </div>
  );
};
