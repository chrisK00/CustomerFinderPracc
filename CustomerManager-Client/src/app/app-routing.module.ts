import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { TestErrorsComponent } from './components/test-errors/test-errors.component';

const routes: Routes = [
  { path: '', component: HomeComponent }, 
  { path: 'errors', component: TestErrorsComponent },
  { path: '**', component: HomeComponent, pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
