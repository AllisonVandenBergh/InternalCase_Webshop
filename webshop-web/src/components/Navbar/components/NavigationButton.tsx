import { ReactNode } from "react";
import { Link, useLocation } from "react-router-dom";
import ctl from "@netlify/classnames-template-literals";

type LinkProps = {
  className?: string;
  children: ReactNode;
  to: string;
};

export const NavigationButton = ({ className, children, to }: LinkProps) => {
  const location = useLocation();

  const computedContainerClassName = ctl(`
    mr-5
    cursor-pointer
    flex
    items-center
    border-b-2
    p-2
    ${to === location.pathname ? "border-[#00ff00]" : "border-white"}
    ${className}
  `);

  return (
    <div className={computedContainerClassName}>
      <Link to={to}>{children}</Link>
    </div>
  );
};
