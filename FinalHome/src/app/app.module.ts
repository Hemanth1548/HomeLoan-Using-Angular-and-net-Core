import { ForgotService } from './services/forgot.service';
import { UserlogServiceService } from './services/userlog-service.service';
import { UserService } from './services/user.service';
import { PropertyService } from 'src/app/services/property.service';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { LoginComponent } from './login/login.component';
import { CalculatorComponent } from './calculator/calculator.component';
import { FaqComponent } from './faq/faq.component';
import { EmicalculatorComponent } from './emicalculator/emicalculator.component';
import { EligibilitycalculatorComponent } from './eligibilitycalculator/eligibilitycalculator.component';
// import { FormsModule, ReactiveFormsModule } from '@angular/router';
import {MatCardModule} from '@angular/material/card';
import {MatButtonModule} from '@angular/material/button';
import { IncomedetailsComponent } from './application/incomedetails/incomedetails.component';
import { LoandetailsComponent } from './application/loandetails/loandetails.component';
import { PersondetailsComponent } from './application/persondetails/persondetails.component';

import { PropertydetailsComponent } from './application/propertydetails/propertydetails.component';
import { IncomeserviceService } from './services/incomeservice.service';
import { LoanService } from './services/loan.service';
import { PersonService } from './services/person.service';
import { HttpClientModule } from '@angular/common/http';
import { DisplaydetailsComponent } from './application/displaydetails/displaydetails.component';
import { LoantrackerComponent } from './loantracker/loantracker.component';


import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { UloginComponent } from './ulogin/ulogin.component';
import { AdminpanelComponent } from './adminpanel/adminpanel.component';
import { UserdetailsComponent } from './adminpanel/userdetails/userdetails.component';
import { StatusService } from './services/status.service';
import { LoantrackStatusComponent } from './loantracker/loantrack-status/loantrack-status.component';
import { LoanTrackService } from './services/loan-track.service';
import { ForgotComponent } from './ulogin/forgot/forgot.component';
import { ResetComponent } from './ulogin/forgot/reset/reset.component';
@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AboutComponent,
    LoginComponent,
    CalculatorComponent,
    FaqComponent,
    EmicalculatorComponent,
    EligibilitycalculatorComponent,
    IncomedetailsComponent,
    LoandetailsComponent,
    PersondetailsComponent,

    PropertydetailsComponent,
    DisplaydetailsComponent,
    LoantrackerComponent,

ForgotComponent,
    UloginComponent,
    AdminpanelComponent,
    UserdetailsComponent,
    LoantrackStatusComponent,
    ForgotComponent,
    ResetComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    MatCardModule,
    MatButtonModule,
   ReactiveFormsModule,
   HttpClientModule
  ],
  providers: [
    IncomeserviceService,
    LoanService,
    PersonService,
  PropertyService,
  UserService,
  UserlogServiceService,
  StatusService,
  LoanTrackService,
  ForgotService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
