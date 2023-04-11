import { AddOrEditProduct } from "@/pages/AddOrEditProduct/AddOrEditProduct";
import { AdminOverview } from "@/pages/AdminOverview/AdminOverview";
import { ItemList } from "@/pages/ItemList/ItemList";
import { Route, Routes } from "react-router-dom";

// TODO: move to root folder (its more a config than a component)
export const RouteSystem = () => {
  return (
    <Routes>
      <Route path="/" element={<ItemList />}></Route>
      <Route path="/admin" element={<AdminOverview />}></Route>
      <Route path="/add" element={<AddOrEditProduct />}></Route>
      <Route path="/edit/:id" element={<AddOrEditProduct />}></Route>
      {/* TODO: create a 404 page */}
      <Route path="*" element={<>404 Not Found</>}></Route>
    </Routes>
  );
};
