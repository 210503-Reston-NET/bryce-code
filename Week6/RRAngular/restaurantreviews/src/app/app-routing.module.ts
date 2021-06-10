import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddRestaurantsComponent } from './components/add-restaurants/add-restaurants.component';
import { GetRestaurantsComponent } from './components/get-restaurants/get-restaurants.component';

const routes: Routes = [
  {
    path: 'restaurants',
    component: GetRestaurantsComponent
  },
  {
    path: 'addRestaurant',
    component: AddRestaurantsComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }