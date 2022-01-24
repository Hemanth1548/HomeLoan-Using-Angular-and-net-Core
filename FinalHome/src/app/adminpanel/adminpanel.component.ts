
import { Component, Input, OnInit } from '@angular/core';
import { propertyM } from 'src/app/model/propertyM';
import { Router } from '@angular/router';
import { income } from 'src/app/model/income';
import { Loan } from 'src/app/model/loan';
import { Person } from 'src/app/model/person';
import { PropertyService } from '../services/property.service';
import { IncomeserviceService } from '../services/incomeservice.service';
import { LoanService } from '../services/loan.service';
import { PersonService } from '../services/person.service';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-adminpanel',
  templateUrl: './adminpanel.component.html',
  styleUrls: ['./adminpanel.component.css']
})
export class AdminpanelComponent implements OnInit {
  // @Input() personal2: Person;
  users: propertyM[];
  incomes: income[];
  loanes: Loan[];
  personal: Person[];
  personal1: Person;
  formBuilder: any;
  adminForm: any;
  submitted: boolean;
  responseId: propertyM;
  sendForm: FormGroup;

  constructor(private router: Router, private userService: PropertyService, private incomeserviceService: IncomeserviceService) { }
  sendid(user: propertyM) {
    localStorage.setItem("datas", JSON.stringify(user));
    let propertydata = JSON.parse(localStorage.getItem("datas"));
    console.log(JSON.parse(localStorage.getItem("datas")).propertyid);
    this.router.navigate(['/userdetails']);
  }
  ngOnInit(): void {

    this.userService.getUsers()
      .subscribe(data => {
        this.users = data;
      });

    this.incomeserviceService.getIncomes()
      .subscribe(data => {
        this.incomes = data;
      });
  }
  // this.incomeserviceService.getIncomes()
  //   .subscribe(data => {
  //     this.incomes = data;
  //   });
  logout() {
    localStorage.clear();
    alert("Logged out successfully");
    this.router.navigate(['/login']);
  }
}





