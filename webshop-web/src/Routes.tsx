import AddOrEditProduct from "@/pages/AddOrEditProduct/AddOrEditProduct";
import AdminOverview from "@/pages/AdminOverview/AdminOverview";
import ItemList from "@/pages/ItemList/ItemList";
import { Route, Routes as ReactRouters } from "react-router-dom";

export const Routes = () => {
  return (
    <ReactRouters>
      <Route path="/" element={<ItemList />}></Route>
      <Route path="/admin" element={<AdminOverview />}></Route>
      <Route path="/admin/add" element={<AddOrEditProduct />}></Route>
      <Route path="/admin/edit/:id" element={<AddOrEditProduct />}></Route>
      {/* TODO: create a 404 page */}
      <Route path="*" element={<>404 Not Found</>}></Route>
    </ReactRouters>
  );
};
