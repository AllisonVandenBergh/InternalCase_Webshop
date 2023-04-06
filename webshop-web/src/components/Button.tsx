import { ReactNode } from "react";
import ctl from "@netlify/classnames-template-literals";

type ButtonProps = {
  className?: string;
  children: ReactNode;
  outlined?: boolean;
  lowercase?: boolean;
  active?: boolean;
  rounded?: boolean;
  disabled?: boolean;
  loading?: boolean;
  icon?: ReactNode;
  variant?: "primary" | "secondary" | "accent" | "ghost" | "link" | "normal";
  size?: "lg" | "sm" | "xs" | "normal";
};

export const Button = ({
  className,
  children,
  outlined,
  lowercase,
  active,
  rounded,
  disabled,
  icon,
  loading,
  variant = "normal",
  size = "normal",
}: ButtonProps) => {
  const computedClassName = ctl(`
    btn
    ${rounded && "btn-circle"} 
    ${size !== "normal" && `btn-${size}`} 
    ${variant !== "normal" && `btn-${variant}`} 
    ${outlined && "btn-outline"} 
    ${active && "btn-active"} 
    ${disabled && "disabled"} 
    ${lowercase && "lowercase"} 
    ${icon && "gap-2"} 
    ${loading && "loading"} 
    ${className}
  `);

  return (
    <button className={computedClassName}>
      {icon}
      {children}
    </button>
  );
};
