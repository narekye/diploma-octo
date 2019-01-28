import { NgModule } from "@angular/core";
import { TaskRoutingModule } from "./task-routing.module";
import { CommonModule } from "@angular/common";
import { TaskComponent } from "./task.component";

@NgModule({
    declarations: [
        TaskComponent
    ],
    imports: [
        TaskRoutingModule,
        CommonModule
    ]
})
export class TaskModule {

}