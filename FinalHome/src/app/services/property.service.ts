import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { propertyM } from '../model/propertyM';

@Injectable({
  providedIn: 'root'
})
export class PropertyService {
  // private  http:HttpClient;
  // property: propertyM=new propertyM;
  constructor(private  http:HttpClient) { }
  baseUrl:string = 'https://localhost:44370/api';

    
  // Get All Users
  getUsers(){
    return this.http.get<propertyM[]>(this.baseUrl+'/Property');
      }
     
    // Get User By Id
    getUserById(id: number){
    return this.http.get<propertyM>(this.baseUrl+'/Property/'+id);
      }
     
    // Create User
    createUser(property: propertyM) {
    return this.http.post(this.baseUrl+'/Property', property);
      }
     
    // Modify User
    updateUser(property: propertyM) {
    return this.http.put(this.baseUrl + '/Property/' + property.propertyid, property);
      }
     
    // Delete User
    deleteUser(id: number) {
    return this.http.delete(this.baseUrl + '/Property/' + id);
      }
}
