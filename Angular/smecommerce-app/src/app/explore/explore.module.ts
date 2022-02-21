import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { ExploreComponent } from "./explore.component";

@NgModule({
    declarations: [ ExploreComponent],
    imports: [FormsModule],
    exports:[ExploreComponent]
})

export class ExploreModule{

}