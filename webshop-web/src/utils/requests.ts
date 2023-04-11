import { Product } from "@/models/product";

type RequestOptions = {
  method: "GET" | "POST" | "PUT" | "DELETE";
  url: string;
  data?: unknown;
};

class RequestError extends Error {
  constructor(message: string, statusCode?: number) {
    super(message);
    this.name = "RequestError";
  }
}

const requestAsync = async <TResponse>({ method, url, data }: RequestOptions): Promise<TResponse> => {
  const response = await fetch(url, {
    method: method,
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(data),
  });

  if (!response.ok) {
    // const json = await response.json();
    throw new RequestError(response.statusText);
  }

  return response.statusText === "No Content" ? response : response.json();
};

// TODO: move import.meta.env.VITE_API_URL to config.ts file and import it here
// this also fix your typing and default values

// TODO: consider to move to a /api folder, these are no generic utils
export const getAllProducts = async () => {
  return await requestAsync<Product[]>({ method: "GET", url: `${import.meta.env.VITE_API_URL as string}/products` });
};

export const getProduct = async (id: string) => {
  return await requestAsync<Product>({
    method: "GET",
    url: `${import.meta.env.VITE_API_URL as string}/products/${id}`,
  });
};

// TODO: type your return value
export const deleteProduct = async (id: string) => {
  return await requestAsync({ method: "DELETE", url: `${import.meta.env.VITE_API_URL as string}/products/${id}` });
};

// TODO: type your return value
export const createProduct = async (product: Product) => {
  return await requestAsync({
    method: "POST",
    url: `${import.meta.env.VITE_API_URL as string}/products`,
    data: product,
  });
};
