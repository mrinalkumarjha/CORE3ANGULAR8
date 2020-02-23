import { Component, OnInit } from '@angular/core';
import {Employee } from '../Model/Employee';
import {EmployeeService} from '../Service/Employee.service';

@Component({
  selector: 'app-dependency-injection',
  templateUrl: './dependency-injection.component.html',
  styleUrls: ['./dependency-injection.component.css']
})
export class DependencyInjectionComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  temp: Employee;
  fetchdata(): void {
    const obj = new EmployeeService();
    this.temp = obj.GetEmployeeDetails();
  }
}
