import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { PersonService } from './../../services/person.service';





@Component({
  selector: 'app-persondetails',
  templateUrl: './persondetails.component.html',
  styleUrls: ['./persondetails.component.css']
})
export class PersondetailsComponent  {

  personForm: FormGroup;
    submitted: boolean = false;

    constructor(private formBuilder: FormBuilder, private router: Router, private personService:PersonService ) { }
  
  ngOnInit() {
  this.personForm = this.formBuilder.group({
    propertyid:JSON.parse(localStorage.getItem("datas")).propertyid,
    first_Name:['',Validators.required],
    middle_Name:['',Validators.required],
    last_Name:['',Validators.required],
    email_id:['',Validators.required],
    password:['',Validators.required],
    confirm_Password:['',Validators.required],
    phone_No:['',Validators.required],
    dob:['',Validators.required],
    gender:['',Validators.required],
    nationality:['',Validators.required],
    aadhar_No:['',Validators.required],
    pan_No:['',Validators.required],
    squestion:[''],
    answer:['']
  });
  
    }
  
  onSubmit() {
    this.submitted = true;
    if(this.personForm.value!=null){
     return;
        }
    this.personService.createCustomer(this.personForm.value)
    .subscribe( (data: any) => {
      alert("Added Peronal Details Succesfully");
      this.personForm.reset();
    //  this.router.navigate(['displaydetails']);
          });
      }

  

}
