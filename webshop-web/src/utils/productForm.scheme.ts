import { z } from "zod";

// TODO: move to form folder
export const productScheme = z.object({
  name: z
    .string({
      required_error: "Name is required",
    })
    .min(3, { message: "Name must contain at least 3 characters" }),
  description: z
    .string({
      required_error: "Description is required",
    })
    .min(3, { message: "Description must contain at least 3 characters" }),
  sku: z
    .string({
      required_error: "SKU is required",
    })
    .min(8, { message: "Sku must contain at least 8 characters" }),
  basePrice: z
    .number({
      required_error: "Base price is required",
      invalid_type_error: "Price must be a number and be positive",
    })
    .positive(),
  sellPrice: z
    .number({
      required_error: "Sell price is required",
      invalid_type_error: "Price must be a number and be positive",
    })
    .positive(),
  image: z.string().min(1).optional(),
  inStock: z.boolean(),
});

type FormValues = z.infer<typeof productScheme>;
