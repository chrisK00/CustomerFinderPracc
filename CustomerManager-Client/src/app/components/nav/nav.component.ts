import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/_interfaces/user';
import { UserLoginDTO } from 'src/app/_interfaces/userLoginDTO';
import { AuthService } from 'src/app/_services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  user: UserLoginDTO = new UserLoginDTO();

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
