import {Component, OnInit} from '@angular/core';
import {AccountService} from './account.service';
import {Observable} from 'rxjs';
import {AccountFilterModel} from '../shared/models/accout-filter.model';
import { ActivatedRoute, Router } from '@angular/router';


@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.css']
})
export class AccountComponent {

  public accounts: Observable<object>;

  constructor(private accountService: AccountService, private router: Router, private route: ActivatedRoute) {

  }

  public onApplyFilter(accountFilter: AccountFilterModel) {
    this.accounts = this.accountService.getAccountsByFillter(accountFilter);
    console.log(this.accounts);
  }

  public addNewAccount() {
      this.router.navigate([0], { relativeTo: this.route });
  }
}
