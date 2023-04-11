import ctl from "@netlify/classnames-template-literals";
import { ReactNode } from "react";
import { IoCloseOutline } from "react-icons/io5";
import { Button } from "./Button";

type ModalProps = {
  children: ReactNode;
  open: boolean;
  className?: string;
  onCloseButtonClick: () => void;
};

export const Modal = ({
  children,
  open,
  className,
  onCloseButtonClick,
}: ModalProps) => {
  const computedClassName = ctl(`
    modal
    ${open && "modal-open"}
    `);

  const modalBoxClassName = ctl(`
    modal-box
    relative
    ${className}
    `);

  return (
    <>
      <div className={computedClassName}>
        <div className={modalBoxClassName}>
          <Button
            variant="ghost"
            className="btn-circle absolute right-2 top-2"
            onClick={onCloseButtonClick}
          >
            <IoCloseOutline size={22} />
          </Button>
          {children}
        </div>
      </div>
    </>
  );
};
