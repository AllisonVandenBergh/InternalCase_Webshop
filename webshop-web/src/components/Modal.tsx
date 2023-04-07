import ctl from "@netlify/classnames-template-literals";
import { ReactNode } from "react";
import { Button } from "./Button";

type ModalProps = {
  children: ReactNode;
  open: boolean;
  onCloseButtonClick: () => void;
};

export const Modal = ({ children, open, onCloseButtonClick }: ModalProps) => {
  const computedClassName = ctl(`
    modal
    ${open && "modal-open"}
`);

  return (
    <>
      <div className={computedClassName}>
        <div className="modal-box relative">
          <Button
            variant="ghost"
            className="btn-circle absolute right-2 top-2"
            onClick={onCloseButtonClick}
          >
            x
          </Button>
          {children}
        </div>
      </div>
    </>
  );
};
