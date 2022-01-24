import { Component } from "@angular/core";


@Component({
  selector: 'app-eligibilitycalculator',
  templateUrl: './eligibilitycalculator.component.html',
  styleUrls: ['./eligibilitycalculator.component.css']
})
export class EligibilitycalculatorComponent  {

  public income: any;
  
  public num3: any;

  
  div(){
   
    this.num3=(60*0.6*this.income);
  }

}
