import {  Component } from "@angular/core";


@Component(
    {
        selector: 'product',
        templateUrl: './product.component.html',
        styleUrls:['./product.component.css']
    }
)

export class ProductComponent{
    showPrpduct: boolean= false;
 products=[
     {
     name: "Sony TV",
     price: 67999,
     code:"S-11",
     imageUrl: "https://www.sony-asia.com/image/60fc808004d6860e433b5a4cafeb60d2?fmt=pjpeg&resMode=bisharp&wid=354"
    },
    {
        name: "Samsung TV",
        price: 67999,
        code:"S-11",
        imageUrl: "https://www.sony-asia.com/image/60fc808004d6860e433b5a4cafeb60d2?fmt=pjpeg&resMode=bisharp&wid=354"
    },
    {
        name: "LG TV",
        price: 67999,
        code:"S-11",
        imageUrl: "https://www.sony-asia.com/image/60fc808004d6860e433b5a4cafeb60d2?fmt=pjpeg&resMode=bisharp&wid=354"
       },
]

 toggleProduct(){
    this.showPrpduct=!this.showPrpduct;
     console.log("Toggle is clicked")
 }

}