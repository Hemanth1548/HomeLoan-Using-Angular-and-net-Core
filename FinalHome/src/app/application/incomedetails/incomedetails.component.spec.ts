import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IncomedetailsComponent } from './incomedetails.component';

describe('IncomedetailsComponent', () => {
  let component: IncomedetailsComponent;
  let fixture: ComponentFixture<IncomedetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IncomedetailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(IncomedetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
