import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import {Person} from '../model/person';
@Injectable({
  providedIn: 'root'
})
export class PersonService {
  // http:HttpClient;
  constructor(private  http:HttpClient) { }
  baseUrl:string = 'https://localhost:44370/api';
   
  // Get All Users
  getCustomers(){
  return this.http.get<Person[]>(this.baseUrl+'/Customer');
    }
   
  // Get User By Id
  getCustomerById(id: number){
  return this.http.get<Person>(this.baseUrl+'/Customer/'+id);
    }
   
  // Create User
  createCustomer(person: Person) {
  return this.http.post(this.baseUrl+'/Customer', person);
    }
   
  // Modify User
  updateCustomer(id:number,person: Person) {
  return this.http.put(this.baseUrl + '/Customer/' + id, person);
    }
   
  // Delete User
  deleteCustomer(id: number) {
  return this.http.delete(this.baseUrl + '/Customer/' + id);
    }
  
}
