import { config } from "@/config";
import { Product } from "@/models/product";
import { FormValues } from "@/pages/AddOrEditProduct/components/productForm.scheme";
import { request } from "./root";

export const getAllProducts = async () => {
    return await request<Product[]>({ method: "GET", url: `${config.apiUrl}/products` });
  };
  
export const getProduct = async (id: string) => {
    return await request<Product>({
        method: "GET",
        url: `${config.apiUrl}/products/${id}`,
    });
};
  
export const deleteProduct = async (id: string) => {
    return await request<Product>({ method: "DELETE", url: `${config.apiUrl}/products/${id}` });
};

export const createProduct = async (product: FormValues) => {
    return await request<Product>({
        method: "POST",
        url: `${config.apiUrl}/products`,
        data: product,
    });
};
  