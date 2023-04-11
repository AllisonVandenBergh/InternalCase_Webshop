// TODO: split your models from the DTOs (and Form types)

/*
export type ProductDTO = {
  id: string;
  ...
  createdAt: string;
}

export type Product extends Omit<ProductDTO, createdAt | updatedAt> {
  // convert when needed (add mapper functions)
  createdAt: Date
}

type FormValues = {
  name: string;
  description: string;
  sku: string;
  basePrice: number;
  sellPrice: number;
  inStock: boolean;
}
*/

export type Product = {
  id: string;
  name: string;
  description: string;
  sku: string;
  basePrice: number;
  sellPrice: number;
  image: string;
  inStock: boolean;
};
