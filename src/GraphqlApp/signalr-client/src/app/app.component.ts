import { Component } from '@angular/core';
import { PizzaDoughService } from './shared/pizza-dough.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  constructor(private pizzaDoughService: PizzaDoughService) {
    pizzaDoughService.getPizzaDough();
  }

  title = 'signalr-client';
}
