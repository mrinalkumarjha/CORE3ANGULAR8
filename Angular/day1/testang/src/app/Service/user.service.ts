import { HttpClient } from '@angular/common/http';
import { User } from '../Model/user';
import {Observable} from 'rxjs';
import { Injectable } from '@angular/core';

@Injectable()
export class UserService {
    constructor(private obj: HttpClient) {

    }
    GetData(): Observable<User[]> {
       return this.obj.get<User[]>('https://jsonplaceholder.typicode.com/users');
    }

    GetDetails(id: string) {

    }
}
