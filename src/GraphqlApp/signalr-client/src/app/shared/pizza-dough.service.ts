import { Injectable } from '@angular/core';
import { Apollo, gql } from 'apollo-angular';
import { PizzaDoughModel } from './pizza-dough.model';

@Injectable()
export class PizzaDoughService {
  constructor(private apollo: Apollo) {}

  pizzaDoughs: PizzaDoughModel[];

  getPizzaDough() {}
}
