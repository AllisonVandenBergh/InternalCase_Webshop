import { Product } from "../../models/product";
import { products } from "../../helpers/products";

export const AdminOverview = () => {
  return (
    <div className="overflow-x-auto w-full">
      <table className="table w-full">
        <thead>
          <tr>
            <th></th>
            <th>Name</th>
            <th>Base price (€)</th>
            <th>Sell price (€)</th>
            <th>In stock?</th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          {products.map((product) => (
            <tr>
              <td>
                <div className="avatar w-24">
                  <img src={product.image} alt="hamburger" />
                </div>
              </td>
              <td>{product.name}</td>
              <td>{product.basePrice}</td>
              <td>{product.sellPrice}</td>
              <td>{product.inStock ? "Yes" : "No"}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};
