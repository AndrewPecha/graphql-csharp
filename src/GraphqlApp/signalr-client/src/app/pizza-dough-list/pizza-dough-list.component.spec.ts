import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PizzaDoughListComponent } from './pizza-dough-list.component';

describe('PizzaDoughListComponent', () => {
  let component: PizzaDoughListComponent;
  let fixture: ComponentFixture<PizzaDoughListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PizzaDoughListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PizzaDoughListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
