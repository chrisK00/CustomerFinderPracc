import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { NavComponent } from './components/nav/nav.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { JwtInterceptor } from './_interceptors/jwt.interceptor';
import { TestErrorsComponent } from './components/test-errors/test-errors.component';
import { CustomerListComponent } from './components/customers/customer-list/customer-list.component';
import { CustomerDetailComponent } from './components/customers/customer-detail/customer-detail.component';
import { CustomerEditComponent } from './components/customers/customer-edit/customer-edit.component';
import { RegisterComponent } from './components/register/register.component';
import { FormsModule } from '@angular/forms';
import { CustomerCardComponent } from './components/customers/customer-card/customer-card.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    NavComponent,
    TestErrorsComponent,
    CustomerListComponent,
    CustomerDetailComponent,
    CustomerEditComponent,
    CustomerCardComponent,
    RegisterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
