import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EligibilitycalculatorComponent } from './eligibilitycalculator.component';

describe('EligibilitycalculatorComponent', () => {
  let component: EligibilitycalculatorComponent;
  let fixture: ComponentFixture<EligibilitycalculatorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EligibilitycalculatorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EligibilitycalculatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
