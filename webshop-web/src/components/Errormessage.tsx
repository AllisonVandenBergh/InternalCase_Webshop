import { ReactNode } from "react";

export const ErrorMessage = ({ children }: { children: ReactNode }) => {
  return (
    <p className="text-rose-700 font-medium text-sm pl-2 pt-2">{children}</p>
  );
};
