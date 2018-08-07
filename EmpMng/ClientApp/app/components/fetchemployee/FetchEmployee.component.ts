import { Component, Inject } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { Router, ActivatedRoute } from '@angular/router';
import { EmployeeService } from '../../Services/EmpService.service';
@Component({
    templateUrl: './FetchEmployee.component.html'
})
export class FetchEmployeeComponent {
    public empList: EmployeeData[] = [];
    constructor(public http: Http, private _router: Router, private _employeeService: EmployeeService) {
        this.getEmployees();
    }
    getEmployees() {
        this._employeeService.getEmployees().subscribe(
            data => this.empList = data
        )
    }
    delete(employeeID) {
        var ans = confirm("Do you want to delete customer with Id: " + employeeID);
        if (ans) {
            this._employeeService.deleteEmployee(employeeID).subscribe((data) => {
                this.getEmployees();
            }, error => console.error(error))
        }
    }
}
interface EmployeeData {
    employeeId: number;
    firstName: string;
    lastName: string;
    email: string;
    contactNumber: number;
    address: string;
    userName: string;
    password: string;
    gender: string;
    qualification: string;
    experience: string;
    lang: string;
}