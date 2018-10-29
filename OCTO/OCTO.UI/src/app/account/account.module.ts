import {NgModule} from '@angular/core';
import {AccountRoutingModule} from './account-routing.module';
import {AccountComponent} from './account.component';
import {AccountService} from './account.service';

@NgModule({
  declarations: [AccountComponent],
  providers: [AccountService],
  imports: [
    AccountRoutingModule
  ]
})
export class AccountModule {

}


