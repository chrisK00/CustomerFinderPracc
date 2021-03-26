import { Component, OnInit } from '@angular/core';
import { Customer } from 'src/app/_interfaces/customer';
import { AuthService } from 'src/app/_services/auth.service';
import { CustomersService } from 'src/app/_services/customers.service';

@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
  styleUrls: ['./customer-list.component.css']
})
export class CustomerListComponent implements OnInit {

  customers: Customer[];

  constructor(private customersService: CustomersService, public authService: AuthService) { }

  ngOnInit(): void {
    this.loadCustomers();
  }

  loadCustomers() {
    this.customersService.getCustomers().subscribe(customers => this.customers = customers),
      error => console.log(error);
  }
}
