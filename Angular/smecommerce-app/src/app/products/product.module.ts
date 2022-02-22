import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { ProductDetailComponent } from "./product-detail/product-detail.component";
import { ProductComponent } from "./product.component";



@NgModule({
    declarations: [ ProductComponent,ProductDetailComponent],
    imports: [FormsModule,
              CommonModule],
    exports:[ProductComponent]

})

export class ProductModule{
    
}