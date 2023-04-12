import ctl from "@netlify/classnames-template-literals";
import { ReactNode } from "react";

type BadgeProps = {
  children: ReactNode;
  className?: string;
  icon?: ReactNode;
};

const Badge = ({ children, className, icon }: BadgeProps) => {
  const computedClassName = ctl(`
    rounded-md
    border-[1px]
    p-4
    flex
    ${icon} gap-2
    ${className}
  `);

  return (
    <div className={computedClassName}>
      {icon}
      {children}
    </div>
  );
};

export default Badge;
