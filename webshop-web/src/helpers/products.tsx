import { Product } from "../models/product";
import hamburger from "../assets/products/hamburger.jpeg";

export const products: Product[] = [
  {
    id: 0,
    name: "Hamburger",
    description: "This is a hamburger",
    sku: "ABC-123456789",
    sellPrice: "2.40",
    basePrice: "1.20",
    image: hamburger,
    inStock: true,
  },
  {
    id: 1,
    name: "Hamburger2",
    description: "Hamburger2",
    sku: "ABC-987654321",
    sellPrice: "2.40",
    basePrice: "1.20",
    image: hamburger,
    inStock: false,
  },
];
