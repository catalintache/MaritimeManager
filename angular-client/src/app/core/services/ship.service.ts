import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Ship } from '../models/ship';

@Injectable({ providedIn: 'root' })
export class ShipService {
  private api = '/api/ships';
  constructor(private http: HttpClient) {}
  getAll(): Observable<Ship[]> {
    return this.http.get<Ship[]>(this.api);
  }
}