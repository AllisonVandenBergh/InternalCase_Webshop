import { Product } from "@/models/product";

type RequestOptions = {
  url: string;
  method?: "GET" | "POST" | "PUT" | "DELETE";
  data?: unknown
}

const requestAsync = async<TResponse>({url, method = "GET", data}: RequestOptions): Promise<TResponse> => {
  const response = await fetch(url, {
    method: method,
    body: JSON.stringify(data)
  })

  return response.json();
}

export const getAllProducts = async () => {
  return await requestAsync<Product[]>({url: `${import.meta.env.VITE_API_URL as string}/products`});
};