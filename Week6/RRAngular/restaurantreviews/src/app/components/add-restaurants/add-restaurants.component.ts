import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { restaurant } from 'src/app/models/restaurant';
import { RestRevApiService } from 'src/app/services/restrevapi.service';

@Component({
  selector: 'app-add-restaurants',
  templateUrl: './add-restaurants.component.html',
  styleUrls: ['./add-restaurants.component.css']
})
export class AddRestaurantsComponent implements OnInit {
  newRestaurant: restaurant = {
    id: 0,
    name: '',
    city: '',
    state: '',
    reviews: null
  }

  constructor(private restaurantService: RestRevApiService, private router: Router) { }

  ngOnInit(): void {
  }
  onSubmit(): void {
    this.restaurantService.AddARestaurant(this.newRestaurant).then(
      result => {
        alert(`${result.name} has been added`);
        this.GoToRestaurants();
      }
    );
  }
  GoToRestaurants() {
    this.router.navigate(['restaurants'])
  }
}
