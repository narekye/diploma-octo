import {RouterModule, Routes} from '@angular/router';
import {NgModule} from '@angular/core';

const accountRoutes: Routes = [];

@NgModule({
  imports: [RouterModule.forChild(accountRoutes)],
  exports: [RouterModule]
})
export class AccountsRoutingModule {

}

