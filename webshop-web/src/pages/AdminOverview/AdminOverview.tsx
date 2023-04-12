import Button from "@/components/Button";
import { HiPlus } from "react-icons/hi";
import { useNavigate } from "react-router-dom";
import ProductsTable from "./components/ProductsTable";

const AdminOverview = () => {
  const navigate = useNavigate();

  return (
    <>
      <div className="flex justify-end mb-4">
        <Button
          icon={<HiPlus />}
          outlined
          normalCase
          onClick={() => navigate("/admin/add")}
        >
          Add new product
        </Button>
      </div>
      <ProductsTable />
    </>
  );
};

export default AdminOverview;
