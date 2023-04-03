import { AdminOverview } from "./pages/AdminOverview/AdminOverview";
import { Navbar } from "./components/Navbar";

export const App = () => {
  return (
    <div className="App">
      <Navbar />
      <div className="m-4">
        <AdminOverview />
      </div>
    </div>
  );
};
