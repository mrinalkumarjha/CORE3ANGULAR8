import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http';
import {FormsModule} from '@angular/forms';
import { FormComponent } from './form/form.component';
import { SupplierComponent } from './supplier/supplier.component';

import {RouterModule, Routes} from '@angular/router';
import { DependencyInjectionComponent } from './dependency-injection/dependency-injection.component';

// routes is class for creating route table
const myroute: Routes = [
  {path: 'supp', component: SupplierComponent}
]


@NgModule({
  declarations: [
    AppComponent,
    FormComponent,
    SupplierComponent,
    DependencyInjectionComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, FormsModule,
    RouterModule.forRoot(myroute)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
