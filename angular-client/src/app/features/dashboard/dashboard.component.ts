import { Component, OnInit } from '@angular/core';
import { VoyageService } from '../../core/services/voyage.service';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html'
})
export class DashboardComponent implements OnInit {
  chartData: { name: string; value: number }[] = [];

  constructor(private svc: VoyageService) {}

  ngOnInit() {
    this.svc.getAll().pipe(
      map(vs => {
        const counts: Record<string, number> = {};
        vs.forEach(v => {
          const m = new Date(v.startDate).toLocaleString('default', { month: 'short', year: 'numeric' });
          counts[m] = (counts[m] || 0) + 1;
        });
        return Object.entries(counts).map(([name, value]) => ({ name, value }));
      })
    ).subscribe(res => this.chartData = res);
  }
}