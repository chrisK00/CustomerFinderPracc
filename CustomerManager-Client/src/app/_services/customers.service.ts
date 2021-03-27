import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { of } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { Customer } from '../_interfaces/customer';


@Injectable({
  providedIn: 'root'
})
export class CustomersService {
  baseUrl = environment.apiUrl;
  customers: Customer[] = [];
  constructor(private http: HttpClient) { }

  getCustomers() {
    if (this.customers.length > 0) {
      return of(this.customers);
    }

    return this.http.get<Customer[]>(this.baseUrl + 'customers').pipe(
      map(customers => {
        this.customers = customers;
        return customers;
      })
    );
  }

}
