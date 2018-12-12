import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {AppComponent} from './app.component';
import {AppRoutingModule} from './app-routing.module';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import {SidebarComponent} from './sidebar/sidebar.component';
import {OctoInterceptor} from './interceptor/httpConfig.interceptor';
import {FormsModule} from "@angular/forms";

@NgModule({
    declarations: [
        AppComponent,
        SidebarComponent
    ],
    providers: [
        {provide: HTTP_INTERCEPTORS, useClass: OctoInterceptor, multi: true}
    ],
    imports: [
        BrowserModule,
        HttpClientModule,
        FormsModule,
        AppRoutingModule
    ],
    bootstrap: [AppComponent]
})
export class AppModule {
}
