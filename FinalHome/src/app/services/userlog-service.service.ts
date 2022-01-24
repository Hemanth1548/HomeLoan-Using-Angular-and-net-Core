import { Person } from 'src/app/model/person';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class UserlogServiceService {
  baseUrl:string = 'https://localhost:44370/api';
  constructor(public http: HttpClient, public router: Router) { }

  // service of regestering a user (client)
 
  // service of checking a user credentials (admin/clients/customer)
  checkLogin(Person:Person) {
    return this.http.post(this.baseUrl+'/UserLogin', Person);
      }

  //service to logout from the system
  logout() {
    localStorage.clear();
    alert("Logged out successfully");
    this.router.navigate(['/home']);
  }
}
