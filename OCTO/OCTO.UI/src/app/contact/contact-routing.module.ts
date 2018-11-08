import {RouterModule, Routes} from '@angular/router';
import {NgModule} from '@angular/core';
import {ContactComponent} from './contact.component';

const contactRoutes: Routes = [
  {path: '', component: ContactComponent}
];

@NgModule({
  imports: [RouterModule.forChild(contactRoutes)],
  exports: [RouterModule]
})
export class ContactRoutingModule {

}
