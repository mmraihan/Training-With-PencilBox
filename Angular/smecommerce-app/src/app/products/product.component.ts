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
     imageUrl: "https://www.sony-asia.com/image/60fc808004d6860e433b5a4cafeb60d2?fmt=pjpeg&resMode=bisharp&wid=354"
 }

}