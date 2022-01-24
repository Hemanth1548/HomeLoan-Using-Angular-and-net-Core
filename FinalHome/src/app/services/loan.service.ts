import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import{ Loan } from '../model/loan';
@Injectable({
  providedIn: 'root'
})
export class LoanService {
  // http:HttpClient;
 
  constructor(private  http:HttpClient) { }
  baseUrl:string = "https://localhost:44370/api"
  
  // Get All Users
  getLoans(){
    return this.http.get<Loan[]>(this.baseUrl+'/Loan');
      }
    
    // Get User By Id
    getLoanById(id: number){
    return this.http.get<Loan>(this.baseUrl+'/Loan/'+id);
      }
    
    // Create User
    createLoan(loan: Loan) {
    return this.http.post(this.baseUrl+'/Loan', loan);
      }
    
    // Modify User
    updateLoan(loan: Loan) {
    return this.http.put(this.baseUrl + '/Loan/' + loan.id, loan);
      }
    
    // Delete User
    deleteLoan(id: Loan) {
    return this.http.delete(this.baseUrl + '/Loan/' + id);
      }
    }