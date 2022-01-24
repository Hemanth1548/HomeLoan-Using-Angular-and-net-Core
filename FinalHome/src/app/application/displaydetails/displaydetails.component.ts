import { IncomeserviceService } from './../../services/incomeservice.service';
import { LoanService } from './../../services/loan.service';
import { PersonService } from './../../services/person.service';
import { PropertyService } from './../../services/property.service';
import { Component, OnInit } from '@angular/core';
import { propertyM } from 'src/app/model/propertyM';
import { Params, Router } from '@angular/router';
import { income } from 'src/app/model/income';
import { Loan } from 'src/app/model/loan';
import { Person } from 'src/app/model/person';
import { identifierModuleUrl } from '@angular/compiler';
import { Status } from 'src/app/model/status';
import { StatusService } from 'src/app/services/status.service';

@Component({
  selector: 'app-displaydetails',
  templateUrl: './displaydetails.component.html',
  styleUrls: ['./displaydetails.component.css']
})
export class DisplaydetailsComponent implements OnInit {
  users: propertyM;
  incomes:income;
  loanes:Loan;
  personal:Person;
  user: any;
  private _Activatedroute: any;
  id: any;
  stat:Status;
 
  constructor(private router: Router,  private statusService: StatusService, private userService: PropertyService, private incomeserviceService: IncomeserviceService, private loanesService:LoanService, private personalService:PersonService) { }

  ngOnInit() {
    // this.user = JSON.parse(localStorage.getItem('user'));
   
    this.userService.getUserById(Number(JSON.parse(localStorage.getItem("datas")).propertyid))
    .subscribe((data: propertyM)=> {
               this.users=data;
    });
          this.incomeserviceService.getIncomeById(Number(JSON.parse(localStorage.getItem("datas")).propertyid))
          .subscribe((data: income)=>{
            this.incomes=data;
          });
          this.loanesService.getLoanById(Number(JSON.parse(localStorage.getItem("datas")).propertyid))
          .subscribe((data: Loan)=>{
            this.loanes=data;
          });
          this.personalService.getCustomerById(Number(JSON.parse(localStorage.getItem("datas")).propertyid))
          .subscribe((data: Person)=>{
            this.personal=data;
          });
          this.statusService.getUserById(Number(JSON.parse(localStorage.getItem("datas")).propertyid))
          .subscribe((data: Status)=>{
            this.stat=data;
            console.log(this.stat);
          });
  }
  logout() {
    localStorage.clear();
    alert("Logged out successfully");
    this.router.navigate(['/ulogin']);
  }
}


