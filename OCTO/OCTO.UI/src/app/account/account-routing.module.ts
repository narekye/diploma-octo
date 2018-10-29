import {RouterModule, Routes} from '@angular/router';
import {NgModule} from '@angular/core';
import {AccountComponent} from './account.component';

const accountRoutes: Routes = [
  {path: '', component: AccountComponent}
];

@NgModule({
  imports: [RouterModule.forChild(accountRoutes)],
  exports: [RouterModule]
})
export class AccountRoutingModule {

}
