import { Component, OnInit } from '@angular/core';
import { ShipService } from '../../../core/services/ship.service';
import { Ship } from '../../../core/models/ship';

@Component({
  selector: 'app-ships-list',
  templateUrl: './ships-list.component.html'
})
export class ShipsListComponent implements OnInit {
  ships: Ship[] = [];
  constructor(private svc: ShipService) {}
  ngOnInit() {
    this.svc.getAll().subscribe(data => (this.ships = data));
  }
}