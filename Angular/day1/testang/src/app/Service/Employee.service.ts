import {Employee} from '../Model/Employee';
export class EmployeeService
{
    GetEmployeeDetails(): Employee {
    const obj = new Employee();
    obj.Code = 123;
    obj.Name = 'mrinal';
    return obj;
    }
}