import { Title } from "@/components/Typography";
import { NavigationButton } from "./components/NavigationButton";
import { Profile } from "./components/Profile";
import { NavigationBasket } from "./components/NavigationBasket";

export const Navbar = () => {
  return (
    <div className="border-[1px]">
      <div className="navbar max-w-[1200px] m-auto">
        <div className="flex-1">
          <Title>Euricom Webshop</Title>
        </div>

        <div className="flex-none divide-x">
          <div className="mr-5 flex">
            <NavigationButton to="/admin">Admin panel</NavigationButton>
            <NavigationButton to="/">Items list</NavigationButton>
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
