import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { AccountService } from '../account.service';
import { AccountModel } from 'src/app/shared/models/account.model';

@Component({
  selector: 'app-account-detail',
  templateUrl: './account-detail.component.html',
  styleUrls: ['./account-detail.component.css']
})
export class AccountDetailComponent implements OnInit {

  public account: AccountModel;

  constructor(private route: ActivatedRoute, private accountService: AccountService) { }

  ngOnInit(): void {
    this.route.params.subscribe((params: Params) => {

      let idOfAccount = +params['id'];

      this.accountService.getAccountById(idOfAccount).subscribe(account => {
        if (!account.HasError && account.Data) {
          this.account = account.Data;
        }
      })
    })
  }
}
