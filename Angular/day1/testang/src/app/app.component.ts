import { Component } from '@angular/core';
import { UserService } from './Service/user.service';
import { User } from './Model/user';

@Component({
  selector: 'app-root',
  template:`
  <button (click)="FetchUsers()">List of Users</button>
  <ul>
    <li *ngFor="let ctr of temp">
      ID: {{ctr.id}}
      Name:{{ctr.name}}
      Email:{{ctr.email}}
      </li>

  </ul>`,
  providers: [UserService]
})
export class AppComponent {
  title = 'testang';
   temp:User[]=[];
  constructor(private obj: UserService) {

  }
FetchUsers()
{
this.obj.GetData().subscribe(
  data=> {
this.temp = data;
  },
  err => {
console.log(err);
  }
)
}

}
