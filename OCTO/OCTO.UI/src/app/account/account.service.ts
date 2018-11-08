import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../environments/environment';

@Injectable()
export class AccountService {
  constructor(private http: HttpClient) {
  }

  public getAccounts() {
    return this.http.get(environment.octoURL + '/Account/GetAccounts');
  }

  public getAccountById(id: number) {
    return this.http.get(environment.octoURL + '/Account/GetAccountByIdAsync?accountId' + id);
  }
}
