import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Customer } from 'src/app/_interfaces/customer';
import { AuthService } from 'src/app/_services/auth.service';
import { CustomersService } from 'src/app/_services/customers.service';

@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
  styleUrls: ['./customer-list.component.css']
})
export class CustomerListComponent implements OnInit {
  customers$: Observable<Customer[]>;

  constructor(private customersService: CustomersService, public authService: AuthService) { }

  ngOnInit(): void {
    this.customers$ = this.customersService.getCustomers();
  }


}
