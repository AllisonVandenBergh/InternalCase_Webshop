import { ProductDto } from "@/api/productDto";

export type Product = Omit<ProductDto, "createdAt" | "updatedAt"> & {
  createdAt: Date;
  updatedAt: Date;
};
