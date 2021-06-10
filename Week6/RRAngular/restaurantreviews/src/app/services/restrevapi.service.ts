import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { restaurant } from '../models/restaurant';

@Injectable({
  providedIn: 'root'
})
export class RestRevApiService {
  baseURL:string = 'https://restaurantrevapi.azurewebsites.net/api/restaurants';

  constructor(private http: HttpClient) { }

  GetAllRestaurants(): Promise<restaurant[]>  {
    return this.http.get<restaurant[]>(this.baseURL).toPromise();
  }
  AddARestaurant(newRestaurant: restaurant): Promise<restaurant> {
    return this.http.post<restaurant>(this.baseURL, newRestaurant).toPromise();
  }
}
