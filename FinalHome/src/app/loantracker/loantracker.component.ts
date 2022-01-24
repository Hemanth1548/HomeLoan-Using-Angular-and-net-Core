import { LoanTrackService } from './../services/loan-track.service';
import { Component, OnInit } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Router } from "@angular/router";


@Component({
  selector: 'app-loantracker',
  templateUrl: './loantracker.component.html',
  styleUrls: ['./loantracker.component.css']
})
export class LoantrackerComponent implements OnInit {
  trackerform: FormGroup;
  submitted: boolean;
  constructor(private fb: FormBuilder, public LTService: LoanTrackService, public router: Router) { }

  ngOnInit(): void {

    this.trackerform = this.fb.group({
      propertyid: [''],
      dob: [''],
      phone_No: ['']
    });

  }
  login() {
    this.submitted = true;
    if (this.trackerform.invalid) { return; }
    this.LTService.checkLogin(this.trackerform.value).subscribe((data: any) => {
      // console.log(this.user.adminUsername);

      if (data != null) {
        // console.log("Correct login correct");

        alert("User Verified");
        localStorage.setItem("datas", JSON.stringify(data));
         this.router.navigate(['loantrack-status']);
      }
      else {
        // console.log("Incorrect login deatails");
        alert("Wrong password, Try again");
        this.trackerform.reset();
      }
    });
  }

}
