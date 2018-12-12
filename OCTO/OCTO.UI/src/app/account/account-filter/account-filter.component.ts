import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { AccountFilterModel } from "../../shared/models/accout-filter.model";
import { SharedService } from 'src/app/shared/shared.service';
import { Observable } from 'rxjs';
import { CountryModel } from 'src/app/shared/models/country.model';

@Component({
    selector: 'app-account-filter',
    templateUrl: './account-filter.component.html',
    styleUrls: ['./account-filter.component.css']
})
export class AccountFilterComponent implements OnInit {

    public countries: Array<CountryModel>;

    ngOnInit(): void {
        this.sharedService.getCountries().subscribe(response => {
            if (!response.HasError)
                this.countries = response.Data;
        });
    }

    constructor(private sharedService: SharedService) {
        this.accountFilter = new AccountFilterModel();
    }

    public accountFilter: AccountFilterModel;

    @Output() filterApplied: EventEmitter<AccountFilterModel> = new EventEmitter();

    public applyFilter(): void {
        this.filterApplied.emit(this.accountFilter);
    }
}
