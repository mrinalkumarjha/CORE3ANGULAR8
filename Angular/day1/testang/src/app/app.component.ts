import { Component } from '@angular/core';
import { UserService } from './Service/user.service';
import { User } from './Model/user';
import { walk } from './Service/walk.service';

@Component({
  selector: 'app-root',
  template:`
  <button (click)="FetchUsers()">List of Users</button>
  <!-- <button (click)="ctr=walk()">Walk</button> -->
  <!-- {{ctr}} -->
  <!-- <ul>
    <li *ngFor="let ctr of temp">
      ID: {{ctr.id}}
      Name:{{ctr.name}}
      Email:{{ctr.email}}
      </li>

  </ul> -->
  <app-form></app-form>
  <app-dependency-injection></app-dependency-injection>
  <!-- <app-directive><app-directive> -->
<nav>
  <a routerLink='/supp'>Supplier</a>
  <router-outlet></router-outlet>
</nav>


  `,
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

walk(): string {
  const obj = new walk();
  return obj.walkNoida();
}

}
