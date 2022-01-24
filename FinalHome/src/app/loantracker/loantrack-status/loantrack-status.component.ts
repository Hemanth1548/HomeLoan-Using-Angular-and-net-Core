import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { income } from 'src/app/model/income';
import { Loan } from 'src/app/model/loan';
import { Person } from 'src/app/model/person';
import { propertyM } from 'src/app/model/propertyM';
import { Status } from 'src/app/model/status';
import { IncomeserviceService } from 'src/app/services/incomeservice.service';
import { LoanService } from 'src/app/services/loan.service';
import { PersonService } from 'src/app/services/person.service';
import { PropertyService } from 'src/app/services/property.service';
import { StatusService } from 'src/app/services/status.service';

@Component({
  selector: 'app-loantrack-status',
  templateUrl: './loantrack-status.component.html',
  styleUrls: ['./loantrack-status.component.css']
})
export class LoantrackStatusComponent implements OnInit {
  users: propertyM;
  incomes:income;
  loanes:Loan;
  personal:Person;
  user: any;
  private _Activatedroute: any;
  id: any;
  stat:Status;
  constructor(private router: Router,  private statusService: StatusService, private userService: PropertyService, private incomeserviceService: IncomeserviceService, private loanesService:LoanService, private personalService:PersonService) { }

  ngOnInit(): void {
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

}
