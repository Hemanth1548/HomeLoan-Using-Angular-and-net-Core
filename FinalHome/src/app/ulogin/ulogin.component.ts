import { UserlogServiceService } from './../services/userlog-service.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';


@Component({
  selector: 'app-ulogin',
  templateUrl:'./ulogin.component.html',
  styleUrls: ['./ulogin.component.css']
})
export class UloginComponent implements OnInit {
  userform: FormGroup;
  submitted: boolean;
  constructor(private fb: FormBuilder, public UserlogServiceService:UserlogServiceService, public router: Router) { }

  ngOnInit(): void {

    this.userform = this.fb.group({
      email_id:[''],
      password:['']

    });

  }
  login() {
    this.submitted = true;
    if (this.userform.invalid) { return; }
    this.UserlogServiceService.checkLogin(this.userform.value).subscribe((data: any) => {
      // console.log(this.user.adminUsername);

      if (data != null) {
        // console.log("Correct login correct");
      
        alert("Logged in successfully");
        localStorage.setItem("datas", JSON.stringify(data));
        this.router.navigate(['application/displaydetails']);
      }
      else {
        // console.log("Incorrect login deatails");
        alert("Wrong password, Try again");
        this.userform.reset();
      }
    });
  }
  logout() {
    localStorage.clear();
    alert("Logged out successfully");
    this.router.navigate(['/ulogin']);
  }
}
