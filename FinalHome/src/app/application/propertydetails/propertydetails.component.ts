import { propertyM } from 'src/app/model/propertyM';


import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { PropertyService } from 'src/app/services/property.service';

@Component({
  selector: 'app-propertydetails',
  templateUrl: './propertydetails.component.html',
  styleUrls: ['./propertydetails.component.css']
})
export class PropertydetailsComponent implements OnInit {

 
  propertyform: FormGroup;
submitted: boolean = false;
  propertyM: string;

 
constructor(private formBuilder: FormBuilder, private router: Router,private propertyServices: PropertyService ) { }

ngOnInit() {
this.propertyform = this.formBuilder.group({
  // propertyid:localStorage.getItem('propertyM'),
  propertyLocation: ['',Validators.required],
  propertyName: ['',Validators.required],
  estimatedAmount: ['',Validators.required]
});

}

onSubmit() {
this.submitted = true;
if(this.propertyform.invalid) { alert("Invaild Details");}
this.propertyServices.createUser(this.propertyform.value)
.subscribe( (data: any) => {
  alert("Added Property Details");
  localStorage.setItem("datas", JSON.stringify(data));
  let propertydata = JSON.parse(localStorage.getItem("datas"));
  console.log(JSON.parse(localStorage.getItem("datas")).propertyid);
 // console.log(JSON.stringify(data,'propertyid'));
  // console.log(JSON.parse(localStorage.getItem("datas"));
  this.propertyform.reset();
// this.router.navigate(['incomedetails']);
    });
}

}
