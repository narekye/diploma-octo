import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { ResponseModel } from "./response.model";
import { CountryModel } from "./models/country.model";
import { environment } from "src/environments/environment";

@Injectable()
export class SharedService {
    constructor(private client: HttpClient) {

    }

    public getCountries(): Observable<ResponseModel<Array<CountryModel>>> {
        return this.client.get<ResponseModel<Array<CountryModel>>>(environment.octoURL + "/Reference/GetCountriesAsync");
    }
}