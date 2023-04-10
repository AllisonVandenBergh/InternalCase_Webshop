import { Button } from "@/components/Button";
import { Checkbox } from "@/components/Checkbox";
import { Input } from "@/components/Input";
import { Textarea } from "@/components/Textarea";
import { useNavigate } from "react-router-dom";
import { ImageUpload } from "./components/ImageUpload";
import { AiOutlineSave } from "react-icons/ai";
import { useForm } from "react-hook-form";
import { Product } from "@/models/product";
import { zodResolver } from "@hookform/resolvers/zod";
import { productScheme } from "@/utils/productForm.scheme";
import { useMutation } from "@tanstack/react-query";
import { createProduct } from "@/utils/requests";
import { toast } from "react-toastify";

export const AddOrEditProduct = () => {
  const navigate = useNavigate();
  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm<Product>({
    resolver: zodResolver(productScheme),
  });

  const createMutation = useMutation({
    mutationFn: createProduct,
    onSuccess: (_) => {
      toast.success(`Product is created 👌`);
    },
    onError: (_) => {
      toast.error(`Error creating the new product 🫣`);
    },
  });

  const onSubmit = (newProduct: Product) =>
    createMutation?.mutateAsync(newProduct);

  return (
    <form className="mx-10" onSubmit={handleSubmit(onSubmit)}>
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
        <Button normalCase type="submit" icon={<AiOutlineSave size={18} />}>
          Save
        </Button>
      </div>
      <div className="flex gap-8">
        <ImageUpload />
        <div className="flex flex-col w-11/12 gap-4">
          <Input
            label="Enter the name of the product *"
            placeholder="Enter the name"
            errorMessage={errors.name?.message}
            {...register("name")}
          />
          <div className="flex gap-4">
            <Textarea
              label="Enter a description"
              placeholder="Enter the description *"
              size="lg"
              errorMessage={errors.description?.message}
              {...register("description")}
            />
            <Input
              label="Enter the sku of the product *"
              placeholder="Enter the sku"
              className="w-3/5"
              errorMessage={errors.sku?.message}
              {...register("sku")}
            />
          </div>
          <div className="flex gap-4">
            <Input
              label="Enter the BASE price of the product (in €) *"
              placeholder="Enter the base price"
              errorMessage={errors.basePrice?.message}
              {...register("basePrice", { valueAsNumber: true })}
            />
            <Input
              label="Enter the SELL price of the product (in €) *"
              placeholder="Enter the sell price"
              errorMessage={errors.sellPrice?.message}
              {...register("sellPrice", { valueAsNumber: true })}
            />
          </div>
          <Checkbox
            label="In stock? *"
            className="w-1/6"
            {...register("inStock")}
          />
        </div>
      </div>
    </form>
  );
};
