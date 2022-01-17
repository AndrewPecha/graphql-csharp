import { Injectable } from '@angular/core';
import { Apollo, gql, QueryRef } from 'apollo-angular';
import { PizzaDoughModel } from './pizza-dough.model';

@Injectable({ providedIn: 'root' })
export class PizzaDoughService {
  constructor(private apollo: Apollo) {}

  getAllPizzaDough = gql`
    {
      pizzaDoughs {
        id
        recipeName
        mixTimeInMinutes
        ingredients {
          ingredientName
          amount
          uOM
        }
      }
    }
  `;

  getPizzaDough(): QueryRef<any> {
    return this.apollo.watchQuery({
      query: this.getAllPizzaDough,
    });
  }
}
