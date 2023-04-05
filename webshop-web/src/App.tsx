import { QueryClient, QueryClientProvider } from "@tanstack/react-query";
import { Navbar } from "./components/Navbar/Navbar";
import { AdminOverview } from "./pages/AdminOverview/AdminOverview";
import { BrowserRouter } from "react-router-dom";
import { RouteSystem } from "./components/RouteSystem";

const queryClient = new QueryClient();

export const App = () => {
  return (
    <QueryClientProvider client={queryClient}>
      <BrowserRouter>
        <Navbar />
        <div className="m-auto max-w-[1200px] my-4">
          <RouteSystem />
        </div>
      </BrowserRouter>
    </QueryClientProvider>
  );
};
