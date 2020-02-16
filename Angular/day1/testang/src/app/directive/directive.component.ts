import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-directive',
  templateUrl: './directive.component.html',
  styleUrls: ['./directive.component.css']
})
export class DirectiveComponent implements OnInit {

  ngifvar = true;

  constructor() { }

  ngOnInit() {
  }

  ChangeNgifvar() {
    if(this.ngifvar) {
      this.ngifvar = false;
    }
    else {
      this.ngifvar = true;
    }
  }

}
