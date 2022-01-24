import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Person } from '../model/person';
import { User } from './../model/user';
@Injectable({
  providedIn: 'root'
})
export class LoanTrackService {
 
  baseUrl:string = 'https://localhost:44370/api';
  constructor(public http: HttpClient, public router: Router) { }

  // service of regestering a user (client)
 
  // service of checking a user credentials (admin/clients/customer)
  checkLogin(User:Person) {
    return this.http.post(this.baseUrl+'/LoanTracker', User);
      }

  //service to logout from the system
  logout() {
    localStorage.clear();
    alert("Logged out successfully");
    this.router.navigate(['/home']);
  }
}
