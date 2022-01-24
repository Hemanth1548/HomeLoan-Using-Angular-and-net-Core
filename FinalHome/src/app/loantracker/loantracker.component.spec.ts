import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LoantrackerComponent } from './loantracker.component';

describe('LoantrackerComponent', () => {
  let component: LoantrackerComponent;
  let fixture: ComponentFixture<LoantrackerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LoantrackerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LoantrackerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
