import {RouterModule, Routes} from '@angular/router';
import {NgModule} from '@angular/core';
import {AccountComponent} from './account.component';
import {AccountDetailComponent} from './account-detail/account-detail.component';
import {AccountEditComponent} from './account-edit/account-edit.component';

const accountRoutes: Routes = [
  {path: '', component: AccountComponent},
  {path: ':id', component: AccountDetailComponent},
  {path: ':id/edit', component: AccountEditComponent}];

@NgModule({
  imports: [RouterModule.forChild(accountRoutes)],
  exports: [RouterModule]
})
export class AccountRoutingModule {

}
