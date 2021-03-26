import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Customer } from '../_interfaces/customer';


@Injectable({
  providedIn: 'root'
})
export class CustomersService {
  baseUrl = environment.apiUrl;
  constructor(private http: HttpClient) { }

  getCustomers() {
    return this.http.get<Customer[]>(this.baseUrl + 'customers');
  }
}
