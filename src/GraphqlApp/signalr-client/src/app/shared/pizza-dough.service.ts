import { Injectable } from '@angular/core';
import { Apollo, gql } from 'apollo-angular';
import { PizzaDoughModel } from './pizza-dough.model';

@Injectable()
export class PizzaDoughService {
  constructor(private apollo: Apollo) {}

  pizzaDoughs: PizzaDoughModel[];

  getPizzaDough() {
    this.apollo
      .watchQuery({
        query: gql`
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
        `,
      })
      .valueChanges.subscribe((result: any) => {
        console.log(result);
        this.pizzaDoughs = result.data.pizzaDoughs;
      });
  }
}
