import { Component, OnInit } from '@angular/core';
import { PizzaDoughModel } from '../shared/pizza-dough.model';
import { PizzaDoughService } from '../shared/pizza-dough.service';
import { Apollo } from 'apollo-angular';

@Component({
  selector: 'app-pizza-dough-list',
  templateUrl: './pizza-dough-list.component.html',
  styleUrls: ['./pizza-dough-list.component.scss'],
})
export class PizzaDoughListComponent implements OnInit {
  pizzaDoughs: PizzaDoughModel[];

  constructor(
    private pizzaDoughService: PizzaDoughService,
    private apollo: Apollo
  ) {}

  ngOnInit(): void {
    this.pizzaDoughService
      .getPizzaDough()
      .valueChanges.subscribe(({ data, loading }) => {
        this.pizzaDoughs = data.pizzaDoughs;
      });
    console.log(this.pizzaDoughs);
  }
}
