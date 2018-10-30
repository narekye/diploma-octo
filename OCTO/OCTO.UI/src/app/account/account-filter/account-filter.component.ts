import {Component, EventEmitter, Output} from '@angular/core';

@Component({
  selector: 'app-account-filter',
  templateUrl: './account-filter.component.html',
  styleUrls: ['./account-filter.component.css']
})
export class AccountFilterComponent {
  @Output() filterApplied = new EventEmitter();

  public applyFilter(): void {
    this.filterApplied.emit();
  }
}
