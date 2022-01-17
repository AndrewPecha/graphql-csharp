import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class PizzaDoughService {
  constructor(private http: HttpClient) {}

  getPizzaDough() {
    return this.http.get<PizzaDough>();
  }
}
