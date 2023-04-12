type PriceContainerProps = {
  price: number;
  name: string;
  className?: string;
  variant?: "small" | "normal";
};

const PriceContainer = ({
  price,
  name,
  className,
  variant = "normal",
}: PriceContainerProps) => {
  return (
    <div className={`flex ${className}`}>
      <p className="text-xs font-medium mr-1">€</p>
      <div className="flex items-end gap-1">
        <p
          className={`${
            variant === "normal" ? "text-lg" : "text-sm"
          } font-medium`}
        >
          {price.toFixed(2).toString().replace(".", ",")}
        </p>
        <p
          className={`${
            variant === "normal" ? "text-sm" : "text-xs"
          } pb-[1px] italic`}
        >
          {name}
        </p>
      </div>
    </div>
  );
};

export default PriceContainer;
