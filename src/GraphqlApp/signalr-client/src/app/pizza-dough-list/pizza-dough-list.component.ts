import { Component, OnInit } from '@angular/core';
import { PizzaDoughModel } from '../shared/pizza-dough.model';
import { PizzaDoughService } from '../shared/pizza-dough.service';
import * as signalR from '@microsoft/signalr';

@Component({
  selector: 'app-pizza-dough-list',
  templateUrl: './pizza-dough-list.component.html',
  styleUrls: ['./pizza-dough-list.component.scss'],
})
export class PizzaDoughListComponent implements OnInit {
  pizzaDoughs: PizzaDoughModel[];
  private hubConnection: signalR.HubConnection;

  constructor(private pizzaDoughService: PizzaDoughService) {}

  ngOnInit(): void {
    this.populatePizzaDoughsFromGraphql();
    this.startSignalRConnection();
  }

  startSignalRConnection = () => {
    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl('https://localhost:7033/pizzaDough')
      .build();

    this.hubConnection
      .start()
      .then(() => console.log('connection started!'))
      .catch((err) => console.log('error while starting connection: ' + err));

    this.hubConnection.on('pizzaDoughAdd', (data) => {
      this.addNewPizzaDough(data);
    });
  };

  populatePizzaDoughsFromGraphql() {
    this.pizzaDoughService
      .getPizzaDough()
      .valueChanges.subscribe(({ data, loading }) => {
        this.pizzaDoughs = data.pizzaDoughs;
      });
    console.log(this.pizzaDoughs);
  }

  addNewPizzaDough(data: PizzaDoughModel) {
    try {
      this.pizzaDoughs = [...this.pizzaDoughs, data];
    } catch (e) {
      console.log(e);
    }
  }
}
