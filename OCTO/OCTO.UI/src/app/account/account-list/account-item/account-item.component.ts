import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router, Params } from '@angular/router';
import {AccountModel} from '../../../shared/models/account.model';
import {AccountService} from '../../account.service';

@Component({
  selector: '[app-account-item]',
  templateUrl: './account-item.component.html',
  styleUrls: ['./account-item.component.css']
})
export class AccountItemComponent {

  constructor(private router: Router, private route: ActivatedRoute, private accountService: AccountService) {

  }

  @Input() account;

  public showAccountDetails() {
    this.router.navigate([this.account.Id], { relativeTo: this.route });
  }

  public deleteAccountDetails() {
    this.accountService.deleteAccountById(this.account.Id);
  }
}
