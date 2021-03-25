import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ReplaySubject, Subject } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { Customer } from '../_interfaces/customer';
import { CustomerLogin } from '../_interfaces/customerLogin';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  baseUrl = environment.apiUrl;
  private currentCustomer = new ReplaySubject<Customer>(1);
  currentCustomer$ = this.currentCustomer.asObservable();

  constructor(private http: HttpClient) { }

  login(customer: CustomerLogin) {
    return this.http.post(`${this.baseUrl}auth/login`, customer).pipe(
      map((customer: Customer) => {
        if (!customer) {
          return;
        }
        localStorage.setItem('customer', JSON.stringify(customer));
        this.currentCustomer.next(customer);
      })
    )
  }

  logout() {
    localStorage.removeItem('customer');
    this.currentCustomer.next(null);
  }
}
