import { Injectable } from "@angular/core";
import {HttpClient} from "@angular/common/http";
import { Observable } from "rxjs";
import EmployeeData from "src/Models/EmployeData";

@Injectable({providedIn: 'root'})
export class EmployeeDataService{

    constructor(private httpClient:HttpClient){

    }

    public getTotalHoursWorked():Observable<Object> {
        return this.httpClient.get("https://localhost:7130/api/Employee");
    }
}