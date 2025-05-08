import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShipsListComponent } from './list/ships-list.component';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [ShipsListComponent],
  imports: [
    CommonModule,
    RouterModule.forChild([{ path: '', component: ShipsListComponent }])
  ]
})
export class ShipsModule { }