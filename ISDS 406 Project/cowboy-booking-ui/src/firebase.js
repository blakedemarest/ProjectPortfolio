// Import the functions you need from the SDKs you need
import { initializeApp } from "firebase/app";
import { getAnalytics } from "firebase/analytics";
// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
  apiKey: "AIzaSyCMaDzV4JH_CPV1F5u7FvBIS1RkcQz8cQg",
  authDomain: "cowboy-booking-hotel.firebaseapp.com",
  projectId: "cowboy-booking-hotel",
  storageBucket: "cowboy-booking-hotel.firebasestorage.app",
  messagingSenderId: "887858662347",
  appId: "1:887858662347:web:05ea221829b25c294a044e",
  measurementId: "G-W9RX83LV30"
};

// Initialize Firebase
const app = initializeApp(firebaseConfig);
const analytics = getAnalytics(app);