import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { AccountService } from '../account.service';
import { AccountModel } from 'src/app/shared/models/account.model';
import { CountryModel } from 'src/app/shared/models/country.model';
import { SharedService } from 'src/app/shared/shared.service';

@Component({
  selector: 'app-account-detail',
  templateUrl: './account-detail.component.html',
  styleUrls: ['./account-detail.component.css']
})
export class AccountDetailComponent implements OnInit {

  public account: AccountModel;
  private accountId: number;
  public countries: CountryModel[];

  constructor(private route: ActivatedRoute, private accountService: AccountService, private sharedService: SharedService) { }

  ngOnInit(): void {

    this.sharedService.getCountries().subscribe(response => {
      console.log(this.countries);
      if (!response.HasError)
        this.countries = response.Data;
    });

    this.route.params.subscribe((params: Params) => {

      this.accountId = +params['id'];

      if (this.accountId === 0) {
        this.account = new AccountModel();
        return;
      }

      this.accountService.getAccountById(this.accountId).subscribe(account => {
        if (!account.HasError && account.Data) {
          this.account = account.Data;
        }
      });
    });
  }

  public onSubmit(): void {
    if (this.accountId === 0) {
      this.accountService.addAccount(this.account);
    }
    else {
      // call update account
    }
  }
}
