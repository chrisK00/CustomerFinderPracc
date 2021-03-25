import { Component, OnInit } from '@angular/core';
import { Customer } from 'src/app/_interfaces/customer';
import { CustomerLogin } from 'src/app/_interfaces/customerLogin';
import { AuthService } from 'src/app/_services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  customer: CustomerLogin = new CustomerLogin();

  constructor(public authService: AuthService) { }

  ngOnInit(): void {
  }

  login() {
    this.authService.login(this.customer).subscribe();
  }

  logout() {
    this.authService.logout();
  }

}
