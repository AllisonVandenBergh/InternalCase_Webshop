import ctl from "@netlify/classnames-template-literals";

type CheckboxProps = {
  checked?: boolean;
  disabled?: boolean;
  size?: "lg" | "md" | "sm" | "xs";
  label?: string;
  className?: string;
};

export const InputCheckbox = ({
  checked,
  label,
  disabled,
  size = "md",
  className,
}: CheckboxProps) => {
  const computedClassname = ctl(`
        form-control    
        ${className}
    `);

  return (
    <div className={computedClassname}>
      <label className="label cursor-pointer">
        <span className="label-text font-medium">{label}</span>
        <input
          type="checkbox"
          checked={checked}
          className={`checkbox checkbox-${size}`}
          disabled={disabled}
        />
      </label>
    </div>
  );
};
