import {NgModule} from '@angular/core';
import {AccountRoutingModule} from './account-routing.module';
import {AccountComponent} from './account.component';
import {AccountService} from './account.service';
import {AccountFilterComponent} from './account-filter/account-filter.component';
import {AccountDetailComponent} from './account-detail/account-detail.component';
import {AccountListComponent} from './account-list/account-list.component';
import {AccountItemComponent} from './account-list/account-item/account-item.component';
import {CommonModule} from '@angular/common';
import {AccountHeaderComponent} from './account-list/account-header/account-header.component';
import {AccountEditComponent} from './account-edit/account-edit.component';
import {FormsModule} from "@angular/forms";
import { SharedModule } from '../shared/shared.module';

@NgModule({
  declarations: [
    AccountComponent,
    AccountFilterComponent,
    AccountDetailComponent,
    AccountListComponent,
    AccountItemComponent,
    AccountHeaderComponent,
    AccountEditComponent
  ],
  providers: [AccountService],
  imports: [
    AccountRoutingModule,
    CommonModule,
    FormsModule
  ]
})
export class AccountModule {

}


