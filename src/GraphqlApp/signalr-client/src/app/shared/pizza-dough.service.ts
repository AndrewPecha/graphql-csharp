import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PizzaDoughModel } from './pizza-dough.model';

@Injectable()
export class PizzaDoughService {
  constructor(private http: HttpClient) {}

  baseUri: string = 'https://localhost:7033/';

  getPizzaDough() {}
}
