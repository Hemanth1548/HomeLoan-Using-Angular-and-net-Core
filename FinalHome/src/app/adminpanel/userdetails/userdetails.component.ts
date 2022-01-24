import { StatusService } from './../../services/status.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { income } from 'src/app/model/income';
import { Loan } from 'src/app/model/loan';
import { Person } from 'src/app/model/person';
import { propertyM } from 'src/app/model/propertyM';
import { IncomeserviceService } from 'src/app/services/incomeservice.service';
import { LoanService } from 'src/app/services/loan.service';
import { PersonService } from 'src/app/services/person.service';
import { PropertyService } from 'src/app/services/property.service';

@Component({
  selector: 'app-userdetails',
  templateUrl: './userdetails.component.html',
  styleUrls: ['./userdetails.component.css']
})
export class UserdetailsComponent implements OnInit {
  users: propertyM;
  incomes: income;
  loanes: Loan;
  personal: Person;
  user: any;
  id: any;
  submitted: boolean;
  approveForm: FormGroup;


  constructor(private formBuilder: FormBuilder, private router: Router, private StatusService: StatusService, private userService: PropertyService, private incomeserviceService: IncomeserviceService, private loanesService: LoanService, private personalService: PersonService) { }

  ngOnInit(): void {
    this.approveForm = this.formBuilder.group({
      propertyid: JSON.parse(localStorage.getItem("datas")).propertyid,
      amount: [],
      status: ['']

    });


    this.userService.getUserById(Number(JSON.parse(localStorage.getItem("datas")).propertyid))
      .subscribe((data: propertyM) => {
        this.users = data;
      });
    this.incomeserviceService.getIncomeById(Number(JSON.parse(localStorage.getItem("datas")).propertyid))
      .subscribe((data: income) => {
        this.incomes = data;
      });
    this.loanesService.getLoanById(Number(JSON.parse(localStorage.getItem("datas")).propertyid))
      .subscribe((data: Loan) => {
        this.loanes = data;
      });
    this.personalService.getCustomerById(Number(JSON.parse(localStorage.getItem("datas")).propertyid))
      .subscribe((data: Person) => {
        this.personal = data;
      });

  }

  onSubmit() {
    this.submitted = true;
    if (this.approveForm.invalid) {
      return;
    }
    this.StatusService.createUser(this.approveForm.value)
      .subscribe(() => {

        alert("Status Updated Succesfully");

        this.approveForm.reset();
        // this.router.navigate(['loandetails']);
      });
  }
  logOutUser():void{
    if(localStorage.getItem("datas")!=null){
   // localStorage.removeItem("datas");
    this.router.navigate(['../about']);
          }
      }
}
