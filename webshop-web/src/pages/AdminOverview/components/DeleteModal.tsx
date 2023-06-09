import Button from "@/components/Button";
import Modal from "@/components/Modal";
import { IoAlertCircleOutline } from "react-icons/io5";

type DeleteModalProps = {
  open: boolean;
  onCancel: () => void;
  onDelete: () => void;
};

const DeleteModal = ({ open, onCancel, onDelete }: DeleteModalProps) => {
  return (
    <Modal open={open} onCloseButtonClick={onCancel}>
      <div className="flex items-center">
        <IoAlertCircleOutline className="mr-2" size={22} color="#fc4242" />
        <h2 className="subHeader">Are you sure?</h2>
      </div>
      <p className="mt-4">
        Do you really want to delete this product? This proces cannot be undone.
      </p>
      <div className="flex justify-end mt-8">
        <Button
          outlined
          className="mr-3"
          variant="accent"
          normalCase
          onClick={onCancel}
        >
          Cancel
        </Button>
        <Button normalCase onClick={onDelete}>
          Delete
        </Button>
      </div>
    </Modal>
  );
};

export default DeleteModal;
