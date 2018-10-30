import {NgModule} from '@angular/core';
import {AccountRoutingModule} from './account-routing.module';
import {AccountComponent} from './account.component';
import {AccountService} from './account.service';
import {AccountFilterComponent} from './account-filter/account-filter.component';
import {AccountDetailComponent} from './account-detail/account-detail.component';
import {AccountListComponent} from './account-list/account-list.component';
import {AccountItemComponent} from './account-list/account-item/account-item.component';
import {CommonModule} from '@angular/common';

@NgModule({
  declarations: [
    AccountComponent,
    AccountFilterComponent,
    AccountDetailComponent,
    AccountListComponent,
    AccountItemComponent
  ],
  providers: [AccountService],
  imports: [
    AccountRoutingModule,
    CommonModule
  ]
})
export class AccountModule {

}


