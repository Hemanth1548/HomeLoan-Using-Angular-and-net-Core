
import{ HttpClient } from'@angular/common/http';
import { Injectable } from '@angular/core';
import{ income } from '../model/income';
@Injectable({
  providedIn: 'root'
})
export class IncomeserviceService {

  // http:HttpClient;
constructor(private  http:HttpClient) { }
baseUrl:string = "https://localhost:44370/api"

// Get All Users
getIncomes(){
  return this.http.get<income[]>(this.baseUrl+'/Employee');
    }
  
  // Get User By Id
  getIncomeById(id: number){
  return this.http.get<income>(this.baseUrl+'/Employee/'+id);
    }
  
  // Create User
  createIncome(income: income) {
  return this.http.post(this.baseUrl+'/Employee', income);
    }
  
  // Modify User
  updateIncome(income: income) {
  return this.http.put(this.baseUrl + '/Employee/' + income.id, income);
    }
  
  // Delete User
  deleteIncome(id: income) {
  return this.http.delete(this.baseUrl + '/Employee/' + id);
    }
}
