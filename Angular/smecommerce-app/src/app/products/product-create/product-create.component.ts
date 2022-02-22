import {  Component, EventEmitter, Input, Output } from "@angular/core";


@Component(
    {
        selector: 'product-create',
        templateUrl: './product-create.component.html',
        styleUrls:['./product-create.component.css']
    }
)

export class ProductCreateComponent{
   @Output() onAdded = new EventEmitter<any>();

    productName: string="";
     productCode: string="";
     productPice: number=0;
     productImageUrl: string="";

    AddProduct(){
        let productObj={
            name: this.productName,
            code: this.productCode,
            price: this.productPice,
            imageUrl: this.productImageUrl,
        }
       this.onAdded.emit(productObj);  
    }
}