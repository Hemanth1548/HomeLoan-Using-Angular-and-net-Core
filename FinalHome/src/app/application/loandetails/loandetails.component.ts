
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { LoanService } from 'src/app/services/loan.service';

@Component({
  selector: 'app-loandetails',
  templateUrl: './loandetails.component.html',
  styleUrls: ['./loandetails.component.css']
})
export class LoandetailsComponent implements OnInit {

  loanForm: FormGroup;
    submitted: boolean = false;
  propertyM: any;
    constructor(private formBuilder: FormBuilder, private router: Router,private loanservice: LoanService ) { }
  
  ngOnInit() {
  this.loanForm = this.formBuilder.group({
    propertyid:JSON.parse(localStorage.getItem("datas")).propertyid,
    max_Loan_Amt:['',Validators.required],
    ROI:['',Validators.required],
    tenure:['',Validators.required],
    loan_Amt:['',Validators.required]
    
  });
  
    }
  
  onSubmit() {
  this.submitted = true;
  if(this.loanForm.invalid){
    alert("Invaild Details");
      }
  this.loanservice.createLoan(this.loanForm.value)
  .subscribe( data => {
    alert("Added Loan Details Succesfully");
    this.loanForm.reset();
  // this.router.navigate(['persondetails']);
        });
    }
}
