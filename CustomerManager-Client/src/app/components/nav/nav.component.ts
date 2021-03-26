import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/_interfaces/user';
import { AuthService } from 'src/app/_services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  user: User = new User();

  constructor(public authService: AuthService) { }

  ngOnInit(): void {
  }

  login() {
    this.authService.login(this.user).subscribe();
  }

  logout() {
    this.authService.logout();
  }

}
