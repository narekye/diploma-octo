import {Component, OnInit} from '@angular/core';
import {AccountService} from './account.service';
import {Observable} from 'rxjs';
import {AccountListComponent} from './account-list/account-list.component';

@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.css']
})
export class AccountComponent implements OnInit {

  public accounts : Observable<object>;

  constructor(private accountService: AccountService) {

  }

  ngOnInit(): void {

  }

  public onApplyFilter() {
    this.accounts = this.accountService.getAccounts();
  }
}
