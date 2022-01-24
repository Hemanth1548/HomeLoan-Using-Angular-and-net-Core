
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { IncomeserviceService } from 'src/app/services/incomeservice.service';
import { PropertyService } from 'src/app/services/property.service';

@Component({
  selector: 'app-incomedetails',
  templateUrl: './incomedetails.component.html',
  styleUrls: ['./incomedetails.component.css']
})
export class IncomedetailsComponent implements OnInit {
  incomeForm: FormGroup;
  submitted: boolean = false;
 


  constructor(private formBuilder: FormBuilder, private userService: PropertyService, private router: Router, 
    private incomeservice: IncomeserviceService
    ) { }

  ngOnInit(): void {
    this.incomeForm = this.formBuilder.group({
      // propertyid:this.foo.results.find(foo.propertyid),
      propertyid:JSON.parse(localStorage.getItem("datas")).propertyid,
      // propertyid: parseInt(localStorage.getItem('propertyid')),
      type_of_Employment:['',Validators.required],
      retirement_Age:['',Validators.required],
     organisation_Type:['',Validators.required],
     employee_Name:['',Validators.required]
          });
      
      
  }
  onSubmit() {
    this.submitted = true;
    if(this.incomeForm.invalid){
      alert("Invaild Details");
        }
       
    
    this.incomeservice.createIncome(this.incomeForm.value)
    .subscribe( data => {
     
      alert("Added Income Details Succesfully");
   
      this.incomeForm.reset();
    // this.router.navigate(['loandetails']);
          });
      }
    }
    



