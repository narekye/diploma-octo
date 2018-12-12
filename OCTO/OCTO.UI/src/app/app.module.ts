import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {AppComponent} from './app.component';
import {AppRoutingModule} from './app-routing.module';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import {SidebarComponent} from './sidebar/sidebar.component';
import {OctoInterceptor} from './interceptor/httpConfig.interceptor';
import {FormsModule} from "@angular/forms";
import { SharedModule } from './shared/shared.module';

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
        SharedModule,
        FormsModule,
        AppRoutingModule
    ],
    bootstrap: [AppComponent]
})
export class AppModule {
}
