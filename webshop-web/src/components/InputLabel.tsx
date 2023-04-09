import ctl from "@netlify/classnames-template-literals";

type InputProps = {
  label?: string;
  placeholder?: string;
  value?: string;
  className?: string;
  size?: "lg" | "md" | "sm" | "xs";
  disabled?: boolean;
};

export const InputLabel = ({
  label,
  placeholder,
  value,
  disabled,
  size = "md",
  className,
}: InputProps) => {
  const computedClassName = ctl(`
        form-control
        w-full
        ${className}
    `);

  return (
    <div className={computedClassName}>
      {label && (
        <label className="label">
          <span className="label-text font-medium">{label}</span>
        </label>
      )}
      <input
        type="text"
        placeholder={placeholder}
        className={`input input-bordered w-full input-${size}`}
        value={value}
        disabled={disabled}
      />
    </div>
  );
};
