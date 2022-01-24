import { Component } from '@angular/core';


@Component({
  selector: 'app-emicalculator',
  templateUrl: './emicalculator.component.html',
  styleUrls: ['./emicalculator.component.css']
})
export class EmicalculatorComponent  {
  
  public loan: any;
  public time: any;
  public roi:Number=8.5;

  public noOfMonths:any;
  public num3: any;
  public monthlyRate:any;
  public oneplusR:any;
  public denominator:any;
  
  div(){
    this.noOfMonths=Number(this.time) *12;
    this.monthlyRate=Number(this.roi)/(12*100)
    this.oneplusR=Math.pow(1+this.monthlyRate,Number(this.noOfMonths))
    this.denominator=this.oneplusR-1;
    
    this.num3=(Number(this.loan)*Number(this.monthlyRate)*(this.oneplusR/this.denominator)).toPrecision(5);
  }
}
