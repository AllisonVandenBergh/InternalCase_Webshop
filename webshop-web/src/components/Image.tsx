import imageNotFound from "@/assets/imageNotFound.png";
import ctl from "@netlify/classnames-template-literals";

type ImageProps = {
  image?: string | null;
  className?: string;
};

const Image = ({ image, className }: ImageProps) => {
  const computedClassname = ctl(`
        rounded 
        overflow-hidden
        ${className}
    `);

  return (
    <div className={computedClassname}>
      <img
        src={image ? image : imageNotFound}
        onError={({ currentTarget }) => {
          currentTarget.onerror = null;
          currentTarget.src = imageNotFound;
        }}
      />
    </div>
  );
};

export default Image;
