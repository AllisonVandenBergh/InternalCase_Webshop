import { Button } from "@/components/Button";
import { HiPlus } from "react-icons/hi";
import { ProductsTable } from "./components/ProductsTable";

export const AdminOverview = () => {
  return (
    <>
      <div className="flex justify-end mb-4">
        <Button icon={<HiPlus />} outlined normalCase>
          Add new product
        </Button>
      </div>
      <ProductsTable />
    </>
  );
};
