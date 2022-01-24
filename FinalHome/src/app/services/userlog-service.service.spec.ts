import { TestBed } from '@angular/core/testing';

import { UserlogServiceService } from './userlog-service.service';

describe('UserlogServiceService', () => {
  let service: UserlogServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UserlogServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
