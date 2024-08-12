import { StrictMode } from 'react';
import { createRoot } from 'react-dom/client';
import { createBrowserRouter, Route, RouterProvider } from 'react-router-dom';
import './index.css';

import Root, {loader as rootLoader} from "./routes/root";
import ErrorPage from './error-page';
import Contact from './routes/contact';
import About from './about';

const router = createBrowserRouter([
  {
    path:"/",
    element: <Root/>,
    errorElement: <ErrorPage/>,
    loader: rootLoader,
    children:[
      {
        path: "contacts/:contactId",
        element: <Contact/>
      },
      {
        path:"/about",
        element: <About/>,
        errorElement: <ErrorPage/>,
    
      },
    ],
  },
]);

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <RouterProvider router={router} />
  </StrictMode>,
)
