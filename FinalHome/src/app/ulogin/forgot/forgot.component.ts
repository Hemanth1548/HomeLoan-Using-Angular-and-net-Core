import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { ForgotService } from 'src/app/services/forgot.service';


@Component({
  selector: 'app-forgot',
  templateUrl: './forgot.component.html',
  styleUrls: ['./forgot.component.css']
})
export class ForgotComponent implements OnInit {

  forgotForm: FormGroup;
  submitted: boolean;
  constructor(private fb: FormBuilder, public FService: ForgotService, public router: Router) { }

  ngOnInit(): void {

    this.forgotForm = this.fb.group({
      propertyid: [''],
     squestion:[''],
     answer:['']
    });

  }
  login() {
    this.submitted = true;
    if (this.forgotForm.invalid) { alert("Enter Valid Information"); }
    this.FService.checkLogin(this.forgotForm.value).subscribe((data: any) => {
      // console.log(this.user.adminUsername);

      if (data != null) {
        // console.log("Correct login correct");

        alert("User Verified");
        localStorage.setItem("datas", JSON.stringify(data));
         this.router.navigate(['reset']);
      }
      else {
        // console.log("Incorrect login deatails");
        alert("Details Wrong, Try again!");
        this.forgotForm.reset();
      }
    });
  }


}
