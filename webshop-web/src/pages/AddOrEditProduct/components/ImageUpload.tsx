import { Header1 } from "@/components/Typography";
import { MdOutlineDriveFolderUpload } from "react-icons/md";

export const ImageUpload = () => {
  return (
    <div className="border-[1px] bg-white p-10 w-[250px] h-[225px] rounded-lg flex flex-col items-center justify-center cursor-pointer">
      <MdOutlineDriveFolderUpload size={32} />
      <Header1 className="mt-2">Upload image</Header1>
    </div>
  );
};
