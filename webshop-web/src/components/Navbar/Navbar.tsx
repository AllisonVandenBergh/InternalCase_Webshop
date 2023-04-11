import { Title } from "@/components/Typography";
import { NavLink } from "./components/NavLink";
import { Profile } from "./components/Profile";
import { NavigationBasket } from "./components/NavigationBasket";
import logoEuricom from "@/assets/logoEuricom.png";

export const Navbar = () => {
  return (
    <div className="border-[1px]">
      <div className="navbar max-w-[1200px] m-auto">
        <div className="flex-1 items-center">
          <img
            className="w-[130px] mr-4"
            src={logoEuricom}
            alt="euricom logo"
          />
          <Title className="pb-1">Webshop</Title>
        </div>

        <div className="flex-none divide-x">
          <div className="mr-5 flex">
            <NavLink to="/admin">Admin panel</NavLink>
            <NavLink to="/">Items list</NavLink>
          </div>
          <div className="pl-5 flex align-end">
            <NavigationBasket />
            <Profile />
          </div>
        </div>
      </div>
    </div>
  );
};
