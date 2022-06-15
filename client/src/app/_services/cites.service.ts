import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { City } from '../_models/city';

@Injectable({
  providedIn: 'root'
})
export class CitesService {
  baseUrl = environment.apiUrl;
  private http = inject(HttpClient);

  constructor(
    //private http: HttpClient
  ) { }

  getCites() {
    return this.http.get<City[]>(this.baseUrl + 'cites');
  }
}
