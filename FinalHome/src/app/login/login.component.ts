
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  userform: FormGroup;
  submitted: boolean;

  constructor(private fb: FormBuilder, public userService: UserService, public router: Router) { }

  ngOnInit() {
    this.userform = this.fb.group({
      adminUsername:[''],
      password:['']

    });

  }
  login() {
    this.submitted = true;
    if (this.userform.invalid) { return; }
    this.userService.checkLogin(this.userform.value).subscribe((data: any) => {
      // console.log(this.user.adminUsername);

      if (data != null) {
        // console.log("Correct login correct");
      
        alert("Logged in successfully");
        this.router.navigate(['../adminpanel']);
      }
      else {
        // console.log("Incorrect login deatails");
        alert("Wrong password, Try again");
        this.userform.reset();
      }
    });
  }



  // method of validating the user credentials and redirecting to user (admin) home page 

}