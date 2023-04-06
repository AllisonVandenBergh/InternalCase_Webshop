import { ReactNode } from "react";
import ctl from "@netlify/classnames-template-literals";

type ButtonProps = {
  className?: string;
  children: ReactNode;
  outlined?: boolean;
  normalCase?: boolean;
  active?: boolean;
  rounded?: boolean;
  disabled?: boolean;
  loading?: boolean;
  icon?: ReactNode;
  hoverColor?: string;
  variant?: "primary" | "secondary" | "accent" | "ghost" | "link" | "normal";
  size?: "lg" | "sm" | "xs" | "normal";
};

export const Button = ({
  className,
  children,
  outlined,
  normalCase,
  active,
  rounded,
  disabled,
  hoverColor,
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
    ${normalCase && "normal-case"} 
    ${icon && "gap-2"} 
    ${loading && "loading"}
    ${hoverColor && `hover:${hoverColor}`}
    ${className}
  `);

  return (
    <button className={computedClassName}>
      {icon}
      {children}
    </button>
  );
};
