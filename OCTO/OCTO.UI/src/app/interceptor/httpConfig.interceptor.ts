import { HttpInterceptor, HttpHandler, HttpRequest, HttpResponse, HttpEvent, HttpErrorResponse } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { tap } from 'rxjs/operators'
import { Observable } from "rxjs";
import { ResponseModel } from "../shared/response.model";

@Injectable()
export class OctoInterceptor implements HttpInterceptor {
  intercept(req: HttpRequest<any>, next: HttpHandler) {
    return next.handle(req).pipe(tap(event => {
      let response = event as HttpResponse<ResponseModel<any>>;
      if (response.body === undefined || response.body.HasError || response.body.Data == null || response.body.Data === undefined) {
        return Observable.create();
      }
    }, error => {

      if (error instanceof HttpErrorResponse) {
        let err = error as HttpErrorResponse;
        if (!err.ok) {
          alert("Something went wrong");
          return Observable.create([]);
        }
      }
    }));
  }
}
