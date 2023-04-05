import { HiLogout } from "react-icons/hi";
import profileImage from "@/assets/profileImage.jpeg";
import { Button } from "@/components/Button";

export const Profile = () => {
  return (
    <div className="dropdown dropdown-end">
      <Button rounded className="avatar" variant="ghost">
        <div className="rounded-full">
          <img src={profileImage} className="object-fill" />
        </div>
      </Button>
      <ul className="menu menu-compact dropdown-content p-2 shadow bg-zinc-50 rounded-box w-52">
        <li>
          <a>
            <HiLogout />
            Logout
          </a>
        </li>
      </ul>
    </div>
  );
};
