import ctl from "@netlify/classnames-template-literals";
import { forwardRef } from "react";

type CheckboxProps = {
  checked?: boolean;
  disabled?: boolean;
  size?: "lg" | "md" | "sm" | "xs";
  label?: string;
  className?: string;
};

export const Checkbox = forwardRef<HTMLInputElement, CheckboxProps>(
  ({ checked, label, disabled, size = "md", className, ...rest }, ref) => {
    const computedClassname = ctl(`
        form-control    
        ${className}
    `);

    return (
      <div className={computedClassname}>
        <label className="label cursor-pointer">
          <span className="label-text font-medium">{label}</span>
          <input
            ref={ref}
            type="checkbox"
            checked={checked}
            className={`checkbox checkbox-${size}`}
            disabled={disabled}
            {...rest}
          />
        </label>
      </div>
    );
  }
);
