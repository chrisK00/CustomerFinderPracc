import { Component, OnInit } from '@angular/core';
import { Customer } from 'src/app/_interfaces/customer';
import { CustomerService } from 'src/app/_services/customer.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  customers: Customer[];

  constructor(private customerService: CustomerService) { }

  ngOnInit(): void {
    this.loadCustomers();
  }

  loadCustomers() {
    this.customerService.getCustomers().subscribe(customers => this.customers = customers), error =>
      console.log(error);
  }

}
