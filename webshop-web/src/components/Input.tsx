import ctl from "@netlify/classnames-template-literals";
import { forwardRef } from "react";
import { ErrorMessage } from "./Errormessage";

type InputProps = {
  label?: string;
  placeholder?: string;
  value?: string;
  className?: string;
  size?: "lg" | "md" | "sm" | "xs";
  disabled?: boolean;
  errorMessage?: string;
};

export const Input = forwardRef<HTMLInputElement, InputProps>(
  (
    {
      label,
      placeholder,
      value,
      disabled,
      size = "md",
      className,
      errorMessage,
      ...rest
    },
    ref
  ) => {
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
          ref={ref}
          placeholder={placeholder}
          className={`input input-bordered w-full input-${size}`}
          value={value}
          disabled={disabled}
          {...rest}
        />
        {errorMessage && <ErrorMessage>{errorMessage}</ErrorMessage>}
      </div>
    );
  }
);
