import {Component, EventEmitter, OnInit, Output} from '@angular/core';
import {AccountFilterModel} from "../../shared/models/accout-filter.model";

@Component({
    selector: 'app-account-filter',
    templateUrl: './account-filter.component.html',
    styleUrls: ['./account-filter.component.css']
})
export class AccountFilterComponent {

    constructor() {
        this.accountFilter = new AccountFilterModel();
    }

    public accountFilter: AccountFilterModel;

    @Output() filterApplied: EventEmitter<AccountFilterModel> = new EventEmitter();

    public applyFilter(): void {
        this.filterApplied.emit(this.accountFilter);
    }
}
