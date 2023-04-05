import { AdminOverview } from "@/pages/AdminOverview/AdminOverview";
import { ItemList } from "@/pages/ItemList/ItemList";
import { Route, Routes } from "react-router-dom";

export const RouteSystem = () => {
  return (
    <Routes>
      <Route path="/" element={<ItemList />}></Route>
      <Route path="/admin" element={<AdminOverview />}></Route>
      {/* TODO: create a 404 page */}
      <Route path="*" element={<>404 Not Found</>}></Route>
    </Routes>
  );
};
