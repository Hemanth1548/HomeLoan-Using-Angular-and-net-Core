import { Status } from './../model/status';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StatusService {
  constructor(private  http:HttpClient) { }
  baseUrl:string = 'https://localhost:44370/api';

    
  // Get All Users
  getUsers(){
    return this.http.get<Status[]>(this.baseUrl+'/Status');
      }
     
    // Get User By Id
    getUserById(id: number){
    return this.http.get<Status>(this.baseUrl+'/Status/'+id);
      }
     
    // Create User
    createUser(property: Status) {
    return this.http.post(this.baseUrl+'/Status', property);
      }
     
    // Modify User
    updateUser(id:Number,property: Status) {
    return this.http.put(this.baseUrl + '/Status/' + property.propertyid, property);
      }
     
    // Delete User
    deleteUser(id: number) {
    return this.http.delete(this.baseUrl + '/Status/' + id);
      }
}
