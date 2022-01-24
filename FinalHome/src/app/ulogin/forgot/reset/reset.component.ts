import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { PersonService } from 'src/app/services/person.service';

@Component({
  selector: 'app-reset',
  templateUrl: './reset.component.html',
  styleUrls: ['./reset.component.css']
})
export class ResetComponent implements OnInit {
  submitted: boolean;
  addform: FormGroup;
  constructor(private formbuilder:FormBuilder, private router: Router, private personService:PersonService) { }

  ngOnInit() {
   
      this.addform = this.formbuilder.group({
        propertyid:JSON.parse(localStorage.getItem("datas")).propertyid,
    first_Name:JSON.parse(localStorage.getItem("datas")).first_Name,
    middle_Name:JSON.parse(localStorage.getItem("datas")).middle_Name,
    last_Name:JSON.parse(localStorage.getItem("datas")).last_Name,
    email_id:JSON.parse(localStorage.getItem("datas")).email_id,
    password:['',Validators.required],
    confirm_Password:['',Validators.required],
    phone_No:JSON.parse(localStorage.getItem("datas")).phone_No,
    dob:JSON.parse(localStorage.getItem("datas")).dob,
    gender:JSON.parse(localStorage.getItem("datas")).gender,
    nationality:JSON.parse(localStorage.getItem("datas")).nationality,
    aadhar_No:JSON.parse(localStorage.getItem("datas")).aadhar_No,
    pan_No:JSON.parse(localStorage.getItem("datas")).pan_No,
    squestion:JSON.parse(localStorage.getItem("datas")).squestion,
    answer:JSON.parse(localStorage.getItem("datas")).answer
      });
  }

  onSubmit() {
    this.submitted = true;
    if(this.addform.invalid){
    return;
        }
        if(this.addform.controls['password'].value == this.addform.controls['confirm_Password'].value){
      
    this.personService.updateCustomer(Number(JSON.parse(localStorage.getItem("datas")).propertyid),this.addform.value)
    .subscribe(
            data => {
    this.router.navigate(['ulogin']);
            },
            (error) => {
              console.log(error);
              alert('Invalid Data');
            // error => {
            //   alert(error);
            });
          }
          else{ alert("Passwords Does not Match!!")}
      }
    }

