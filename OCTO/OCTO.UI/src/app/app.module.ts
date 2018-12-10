import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {AppComponent} from './app.component';
import {AppRoutingModule} from './app-routing.module';
import { HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import {SidebarComponent} from './sidebar/sidebar.component';
import { OctoInterceptor } from './interceptor/httpConfig.interceptor';

@NgModule({
  declarations: [
    AppComponent,
    SidebarComponent
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: OctoInterceptor, multi: true }
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
}
