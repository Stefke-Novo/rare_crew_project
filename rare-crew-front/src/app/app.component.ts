import { Component } from '@angular/core';
import { EmployeeDataService } from 'src/Services/EmployeeData.service';
import Chart, { ChartConfiguration, ChartData, ChartOptions } from 'chart.js/auto';
import EmployeeData from 'src/Models/EmployeData';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'rare-crew-front';
  public employeeData:EmployeeData[] = [];
  public data = {};
  public config = {};
  public chart!:Chart;

  constructor(employeeDataService:EmployeeDataService){
    employeeDataService.getTotalHoursWorked()
    .subscribe((data)=>{ 
      //let totalHours = this.employeeData.map(e=>e.totalHoursWorked).reduce((e,e1)=>e+e1);
      this.employeeData=data as EmployeeData[];
      let totalHours = this.employeeData.map(e=>e.totalHoursWorked).reduce((e,e1)=>e+e1);
      this.data = {
        labels: this.employeeData.map(e=>e.name),
        datasets: [{
          label: 'Total hours worked (%)',
          data: this.employeeData.map(e=>Math.round(e.totalHoursWorked/totalHours*100)),
          backgroundColor: this.employeeData.map(e=>
            {
                var x = Math.floor(Math.random() * 256);
                var y = Math.floor(Math.random() * 256);
                var z = Math.floor(Math.random() * 256);
              return 'rgb('+x+","+y+","+z+")";
            }),
          hoverOffset: 4
        }]
      };
      this.config ={
        type: 'pie',
        data: this.data,
        options:{
          plugins:{
            legend:{
              position:'bottom'
            }
          }
        }
      };
      this.chart = new Chart(
        document.getElementById('employees') as HTMLCanvasElement,
        this.config as ChartConfiguration
      );
    });
  }
  getColor(totalHoursWorked: number): any {
    if(totalHoursWorked<100)
      return "orange";
    return "white";
  }
}
