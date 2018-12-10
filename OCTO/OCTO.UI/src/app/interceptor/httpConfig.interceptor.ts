import { HttpInterceptor, HttpHandler, HttpRequest, HttpResponse, HttpEvent, HttpErrorResponse } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { tap } from 'rxjs/operators'

@Injectable()
export class OctoInterceptor implements HttpInterceptor {
  intercept(req: HttpRequest<any>, next: HttpHandler) {
    return next.handle(req).pipe(tap(event => {
          // Inject here auth token in future
    }, error => {

      if (error instanceof HttpErrorResponse) {
        let err = error as HttpErrorResponse;
        if (!err.ok) {
          const message: string = "Something went wrong";
          alert(message);
        }
      }
    }));
  }
}
