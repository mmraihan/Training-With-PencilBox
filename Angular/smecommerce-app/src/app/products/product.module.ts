import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { ProductCreateComponent } from "./product-create/product-create.component";
import { ProductDetailComponent } from "./product-detail/product-detail.component";
import { ProductComponent } from "./product.component";



@NgModule({
    declarations: [ ProductComponent,ProductDetailComponent, ProductCreateComponent],
    imports: [FormsModule,
              CommonModule],
    exports:[ProductComponent]

})

export class ProductModule{
    
}