import {NgModule} from '@angular/core';
import {PreloadAllModules, RouterModule, Routes} from '@angular/router';

const appRoutes: Routes = [
  {path: 'accounts', loadChildren: './account/account.module#AccountModule'},
  {path: 'contacts', loadChildren: './contact/contact.module#ContactModule'},
  {path: 'tasks', loadChildren: './task/task.module#TaskModule'}
];

@NgModule({
  imports: [RouterModule.forRoot(appRoutes, {
    preloadingStrategy: PreloadAllModules
  })],
  exports: [RouterModule]
})
export class AppRoutingModule {

}
