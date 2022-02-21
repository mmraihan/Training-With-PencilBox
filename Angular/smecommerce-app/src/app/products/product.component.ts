import {  Component } from "@angular/core";


@Component(
    {
        selector: 'product',
        templateUrl: './product.component.html',
        styleUrls:['./product.component.css']
    }
)

export class ProductComponent{
 product={
     name: "Sony TV",
     price: 67999,
     code:"S-11",
 }

}