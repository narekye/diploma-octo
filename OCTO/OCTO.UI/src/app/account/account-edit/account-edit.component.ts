import {Component, OnInit} from '@angular/core';
import {ActivatedRoute, Params} from '@angular/router';
import {AccountService} from '../account.service';

@Component({
  selector: 'app-account-edit',
  templateUrl: './account-edit.component.html'
})
export class AccountEditComponent implements OnInit {

  public currentAccount;
  private id: number;

  constructor(private activatedRoute: ActivatedRoute,
              private accountService: AccountService) {

  }

  ngOnInit(): void {
    this.activatedRoute.params.subscribe((params: Params) => {
      this.id = +params['id'];
      this.getCurrentAccount();
    });
  }

  private getCurrentAccount() {
    this.accountService.getAccountById(this.id).subscribe(response => { });
  }
}
