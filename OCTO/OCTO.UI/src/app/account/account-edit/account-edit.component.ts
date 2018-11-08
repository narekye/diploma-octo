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

  // get id(): number {
  //   return this.id;
  // }
  //
  // set id(value: number) {
  //   this.id = value;
  // }

  constructor(private activatedRoute: ActivatedRoute,
              private accountService: AccountService) {

  }

  ngOnInit(): void {
    this.activatedRoute.params.subscribe((params: Params) => {
      this.id = +params['id'];
      console.log(this.id);
      this.getCurrentAccount();
    });
  }

  private getCurrentAccount() {
    this.accountService.getAccountById(this.id).subscribe(response => {
      console.log(response);
    });
  }
}
