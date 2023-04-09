import ctl from "@netlify/classnames-template-literals";

type TextareaProps = {
  label?: string;
  placeholder?: string;
  value?: string;
  className?: string;
  size?: "lg" | "md" | "sm" | "xs";
  disabled?: boolean;
};

export const InputTextarea = ({
  label,
  placeholder,
  value,
  size = "md",
  disabled,
  className,
}: TextareaProps) => {
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
      <textarea
        placeholder={placeholder}
        className={`textarea textarea-bordered w-full textarea-${size}`}
        value={value}
        disabled={disabled}
      />
    </div>
  );
};
