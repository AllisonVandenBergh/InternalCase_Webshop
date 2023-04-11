import { ReactNode } from "react";
import ctl from "@netlify/classnames-template-literals";

export type TypographyProps = {
  children: ReactNode;
  className?: string;
};

// TODO: don't use <p> for titles
/* 
Better to write

<h2 className="text-xl font-medium">Title</h2>
<h2 className="text-xl font-medium">Title</h2>
<h2 className="text-xl font-medium">Title</h2>

*/

export const Title = ({ children, className }: TypographyProps) => {
  const computedClassNames = ctl(`
    text-xl
    font-medium
    ${className}
  `);

  return <p className={computedClassNames}>{children}</p>;
};

export const Header1 = ({ children, className }: TypographyProps) => {
  const computedClassNames = ctl(`
    text-xl
    font-medium
    ${className}
  `);

  return <p className={computedClassNames}>{children}</p>;
};

export const Header2 = ({ children, className }: TypographyProps) => {
  const computedClassNames = ctl(`
    text-lg
    font-medium
    ${className}
  `);

  return <p className={computedClassNames}>{children}</p>;
};
