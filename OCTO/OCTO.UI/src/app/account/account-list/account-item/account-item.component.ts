import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router, Params } from '@angular/router';

@Component({
  selector: '[app-account-item]',
  templateUrl: './account-item.component.html',
  styleUrls: ['./account-item.component.css']
})
export class AccountItemComponent {

  constructor(private router: Router, private route: ActivatedRoute) {

  }

  @Input() account;

  public showAccountDetails() {
    this.router.navigate([this.account.Id], { relativeTo: this.route });
  }
}
