import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { ProductComponent } from "./product.component";



@NgModule({
    declarations: [ ProductComponent],
    imports: [FormsModule],
    exports:[ProductComponent]

})

export class ProductModule{
    
}