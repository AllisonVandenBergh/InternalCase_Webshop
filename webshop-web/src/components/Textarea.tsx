import ctl from "@netlify/classnames-template-literals";
import { forwardRef } from "react";
import ErrorMessage from "./Errormessage";

type TextareaProps = {
  label?: string;
  placeholder?: string;
  value?: string;
  className?: string;
  size?: "lg" | "md" | "sm" | "xs";
  disabled?: boolean;
  errorMessage?: string;
};

const Textarea = forwardRef<HTMLTextAreaElement, TextareaProps>(
  (
    {
      label,
      placeholder,
      value,
      size = "md",
      disabled,
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
        <textarea
          ref={ref}
          placeholder={placeholder}
          className={`textarea textarea-bordered w-full textarea-${size}`}
          value={value}
          disabled={disabled}
          {...rest}
        />
        {errorMessage && <ErrorMessage>{errorMessage}</ErrorMessage>}
      </div>
    );
  }
);

export default Textarea;
