import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { AuthService } from '../_services/auth.service';
import { take } from 'rxjs/operators';
import { Customer } from '../_interfaces/customer';

@Injectable()
export class JwtInterceptor implements HttpInterceptor {

  constructor(private authService: AuthService) { }

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    let currentCustomer: Customer;
    this.authService.currentCustomer$.pipe(take(1)).subscribe(customer => currentCustomer = customer);

    if (currentCustomer) {
      request = request.clone({
        setHeaders: {
          Authorization: `Bearer ${currentCustomer.token}`
        }
      })
    }
    return next.handle(request);
  }
}
