import { TestBed } from '@angular/core/testing';

import { LoanTrackService } from './loan-track.service';

describe('LoanTrackService', () => {
  let service: LoanTrackService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(LoanTrackService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
