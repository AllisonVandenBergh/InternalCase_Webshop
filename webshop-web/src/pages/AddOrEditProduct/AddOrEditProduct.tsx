import { Button } from "@/components/Button";
import { InputCheckbox } from "@/components/InputCheckbox";
import { InputLabel } from "@/components/InputLabel";
import { InputTextarea } from "@/components/InputTextarea";
import { useNavigate } from "react-router-dom";
import { ImageUpload } from "./components/ImageUpload";
import { AiOutlineSave } from "react-icons/ai";

export const AddOrEditProduct = () => {
  const navigate = useNavigate();

  const onSave = () => {};

  return (
    <div className="mx-10">
      <div className="flex justify-end mt-8">
        <Button
          outlined
          className="mr-3"
          variant="accent"
          normalCase
          onClick={() => navigate(-1)}
        >
          Cancel
        </Button>
        <Button normalCase onClick={onSave} icon={<AiOutlineSave size={18} />}>
          Save
        </Button>
      </div>
      <div className="flex gap-8">
        <ImageUpload />
        <div className="flex flex-col w-11/12 gap-4">
          <InputLabel
            label="Enter the name of the product"
            placeholder="Enter the name"
          />
          <div className="flex gap-2">
            <InputTextarea
              label="Enter a description"
              placeholder="Enter the description"
              size="lg"
            />
            <InputLabel
              label="Enter the sku of the product"
              placeholder="Enter the sku"
              className="w-3/5"
            />
          </div>
          <div className="flex gap-2">
            <InputLabel
              label="Enter the BASE price of the product (in €)"
              placeholder="Enter the base price"
            />
            <InputLabel
              label="Enter the SELL price of the product (in €)"
              placeholder="Enter the sell price"
            />
          </div>
          <InputCheckbox label="In stock?" className="w-1/6" />
        </div>
      </div>
    </div>
  );
};
