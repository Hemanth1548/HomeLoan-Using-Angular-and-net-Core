import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LoantrackStatusComponent } from './loantrack-status.component';

describe('LoantrackStatusComponent', () => {
  let component: LoantrackStatusComponent;
  let fixture: ComponentFixture<LoantrackStatusComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LoantrackStatusComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LoantrackStatusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
