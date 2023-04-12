import { MdOutlineDriveFolderUpload } from "react-icons/md";

const ImageUpload = () => {
  return (
    <div className="border-[1px] bg-white p-10 w-[250px] h-[225px] rounded-lg flex flex-col items-center justify-center cursor-pointer">
      <MdOutlineDriveFolderUpload size={32} />
      <h2 className="mt-2 header">Upload image</h2>
    </div>
  );
};

export default ImageUpload;
