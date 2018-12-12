import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../environments/environment';
import {Observable} from 'rxjs';
import {ResponseModel} from '../shared/response.model';
import {AccountModel} from '../shared/models/account.model';
import {AccountFilterModel} from "../shared/models/accout-filter.model";

@Injectable()
export class AccountService {
    constructor(private http: HttpClient) {
    }

    public getAccounts() {
        return this.http.get(environment.octoURL + '/Account/GetAccounts');
    }

    public getAccountById(id: number): Observable<ResponseModel<AccountModel>> {
        return this.http.get<ResponseModel<AccountModel>>(environment.octoURL + '/Account/GetAccountByIdAsync?accountId=' + id);
    }

    public getAccountsByFillter(accountFillter: AccountFilterModel) {
        return this.http.post(environment.octoURL + '/Account/GetAccountsByFilterAsync', accountFillter);
    }
}
