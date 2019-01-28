import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { TaskComponent } from "./task.component";

const taskRoutes: Routes = [
    {path: '', component: TaskComponent}
];

@NgModule({
    imports: [RouterModule.forChild(taskRoutes)],
    exports: [RouterModule]
})

export class TaskRoutingModule {

}