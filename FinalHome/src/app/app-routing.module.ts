import { ResetComponent } from './ulogin/forgot/reset/reset.component';
import { ForgotComponent } from './ulogin/forgot/forgot.component';
import { LoantrackStatusComponent } from './loantracker/loantrack-status/loantrack-status.component';

import { UserdetailsComponent } from './adminpanel/userdetails/userdetails.component';
import { AdminpanelComponent } from './adminpanel/adminpanel.component';
import { DisplaydetailsComponent } from './application/displaydetails/displaydetails.component';
import { UloginComponent } from './ulogin/ulogin.component';
import { AboutComponent } from './about/about.component';
import { HomeComponent } from './home/home.component';
import {LoginComponent} from"./login/login.component";

// import { DisplaydetailsComponent } from './application/displaydetails/displaydetails.component';
import { CalculatorComponent } from './calculator/calculator.component';
import { FaqComponent } from './faq/faq.component';
import { EmicalculatorComponent } from './emicalculator/emicalculator.component';
import { IncomedetailsComponent } from './application/incomedetails/incomedetails.component';
import { LoandetailsComponent } from './application/loandetails/loandetails.component';
import { PersondetailsComponent } from './application/persondetails/persondetails.component';

import { PropertydetailsComponent } from './application/propertydetails/propertydetails.component';
import { EligibilitycalculatorComponent} from "./eligibilitycalculator/eligibilitycalculator.component";
import { LoantrackerComponent } from './loantracker/loantracker.component';
import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';
const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'about',component:AboutComponent},
  {path: 'login', component: LoginComponent },
  {path: 'application/displaydetails', component: DisplaydetailsComponent },
  {path: 'login/propertydetails/', component: LoginComponent },
  {path: 'login/propertydetails/incomedetails',component:IncomedetailsComponent},
  {path: 'login/propertydetail/incomedetails/loandetails',component:LoandetailsComponent},
  {path: 'login/propertydetails/incomedetails/loandetails/personaldetails/displaydetails',component:DisplaydetailsComponent},
  {path: 'login/about', component: LoginComponent },
  {path: 'calculator',component:CalculatorComponent},
  {path: 'faq',component:FaqComponent},
 
  {path: 'emicalculator',component:EmicalculatorComponent},
  {path:'eligibilitycalculator',component:EligibilitycalculatorComponent},
  {path:'application/incomedetails',component:IncomedetailsComponent},
  {path: 'application/propertydetails',component:PropertydetailsComponent},
  {path:'application/incomedetails/loandetails',component:LoandetailsComponent},
  {path:'application/persondetails',component:PersondetailsComponent},

  {path:'application/loandetails',component:LoandetailsComponent},
  {path:'propertydetails',component:PropertydetailsComponent},
  {path:'incomedetails',component:IncomedetailsComponent},
  {path:'incomedetails/loandetails',component:LoandetailsComponent},
  {path:'incomedetails/loandetails/personaldetails',component:PersondetailsComponent},
  {path:'propertydetails/incomedetails/loandetails/personaldetails/displaydetails',component:DisplaydetailsComponent},
  {path:'incomedetails/loandetails/personaldetails/home',component:HomeComponent},
  {path:'incomedetails/loandetails/personaldetails/home/login',component:LoginComponent},
  {path:'incomedetails/loandetails/personaldetails/home/faq',component:FaqComponent},
 // {path:'**',component:HomeComponent},
  {path:'about/eligibilitycalculator',component:EligibilitycalculatorComponent},
  {path:'about/eligibilitycalculator/emicalculator',component:EmicalculatorComponent},
  {path:'about/eligibilitycalculator/emicalculator/propertydetails',component:PropertydetailsComponent},
  {path:'loantracker',component:LoantrackerComponent},
  {path:'loantrack-status',component:LoantrackStatusComponent},
  {path:'ulogin',component:UloginComponent},
  {path:'adminpanel',component:AdminpanelComponent},
  {path:'displaydetails/:id',component:DisplaydetailsComponent},
  {path:'userdetails',component:UserdetailsComponent},
  {path:'forgot',component:ForgotComponent},
  {path:'reset',component:ResetComponent}
  // {path:'/src/app/loantracker/loantrack-status'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
  
})
export class AppRoutingModule { }
