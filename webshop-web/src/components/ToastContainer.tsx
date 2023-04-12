import { ToastContainer as ReactToastifyContainer } from "react-toastify";

const ToastContainer = () => {
  return (
    <ReactToastifyContainer
      position="top-right"
      autoClose={5000}
      hideProgressBar={false}
      newestOnTop
      closeOnClick
      rtl={false}
      pauseOnFocusLoss
      draggable
      pauseOnHover
      theme="light"
    />
  );
};

export default ToastContainer;
