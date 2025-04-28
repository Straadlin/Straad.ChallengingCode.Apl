import { Routes } from '@angular/router';
import { routes as productRoutes } from './features/product/product-shell/product-routing';

export const routes: Routes = [
  {
    path: 'product',
    children: productRoutes,
  },
  {
    path: '**',
    redirectTo: 'product',
  }
];
