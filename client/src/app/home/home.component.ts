import { Component, inject, OnInit } from '@angular/core';
import { City } from '../_models/city';
import { CitesService } from '../_services/cites.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  cites: City[] = [];
  private citesService = inject(CitesService);

  constructor() { }

  ngOnInit(): void {
    this.getCites();
  }

  getCites() {
    this.citesService.getCites().subscribe(cites => {
      this.cites = cites;
    });
  }
}
