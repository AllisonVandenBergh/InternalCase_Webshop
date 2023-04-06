import { ReactNode } from "react";
import ctl from "@netlify/classnames-template-literals";

export type TypographyProps = {
  children: ReactNode;
  className?: string;
};

export const Title = ({ children, className }: TypographyProps) => {
  const computedClassNames = ctl(`
    text-2xl
    font-medium
    ${className}
  `);

  return <p className={computedClassNames}>{children}</p>;
};

export const Header1 = ({ children, className }: TypographyProps) => {
  const computedClassNames = ctl(`
    text-xl
    ${className}
  `);

  return <p className={computedClassNames}>{children}</p>;
};