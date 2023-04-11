/** @type {import('tailwindcss').Config} */
export default {
  content: ["./index.html", "./src/**/*.{js,ts,jsx,tsx}"],
  theme: {
    extend: {
      colors: {
        euricom: "#00ff00",
      },
    },
  },
  plugins: [require("daisyui")],
  safelist: [
    {
      pattern: /btn-.*/,
    },
  ],
  "editor.quickSuggestions": {
    "strings": true
  }
};
