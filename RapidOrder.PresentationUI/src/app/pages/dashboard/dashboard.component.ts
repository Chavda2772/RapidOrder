import { Component } from '@angular/core';
import { ProductComponent } from './product/product.component';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [ProductComponent],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.scss'
})
export class DashboardComponent {
  productList = [
    {
      "image": "https://www.pcworld.com/wp-content/uploads/2023/06/ASUS_ROG_Zephyrus_G14_GA402_1.jpg?quality=50&strip=all",
      "title": "Asus Zen-19",
      "price": 261
    },
    {
      "image": "https://m.media-amazon.com/images/I/618Z0eTNM6L._AC_UY327_FMwebp_QL65_.jpg",
      "title": "KALL N9 Tablet",
      "price": 99.9
    },
    {
      "image": "https://cdn.dxomark.com/wp-content/uploads/medias/post-121010/Xiaomi-12S-Ultra-featured-image-packshot-review.jpg",
      "title": "Xiaomi Mi 12 Ultra",
      "price": 500
    },
    {
      "image": "https://beebom.com/wp-content/uploads/2017/12/Mi-A1-Review.jpg?w=750&quality=75",
      "title": "Xiaomi A1",
      "price": 200
    },
    {
      "image": "https://s7d1.scene7.com/is/image/canon/5812C002_eos-r50-body-white_primary?fmt=webp-alpha&wid=800",
      "title": "EOS R50 Body",
      "price": 454
    },
    {
      "image": "https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcTofEiBrCz1y0WD917lS6X5XJK6b5GcUsqNce2MgI5S9PkoWxOQIL7SpOxaA-OVeu-giIoBn-TE_hPUUxw2bAhIBfd2FGMlnBZvMAGFpJv0P9IuAZiRPcBY",
      "title": "Sony ZV-1 Digital Camera Advanced",
      "price": 79990
    },
    {
      "image": "https://m.media-amazon.com/images/I/41w9-ptS-uL._SY300_SX300_QL70_FMwebp_.jpg",
      "title": "Sony Alpha ILCE-6100Y",
      "price": 990
    },
    {
      "image": "https://static.javatpoint.com/computer/images/what-is-a-tablet.png",
      "title": "SAMSUNG Galaxy Tab A9 Plus Wi-Fi+5G Android Tablet",
      "price": 899
    },
    {
      "image": "https://m.media-amazon.com/images/I/31aPzW9atKL._SX300_SY300_QL70_FMwebp_.jpg",
      "title": "Samsung Galaxy Book3 Pro ",
      "price": 119990
    },
    {
      "image": "https://image.oppo.com/content/dam/oppo/en/mkt/newsroom/press/oppo-launches-find-x-five-series/img-01.jpg.thumb.webp",
      "title": "Oppo Find X5 Pro",
      "price": 35000
    },
    {
      "image": "https://static.javatpoint.com/computer/images/what-is-a-tablet.png",
      "title": "OnePlus Pad Go 28.82 cm",
      "price": 39999
    },
    {
      "image": "https://m.media-amazon.com/images/G/31/img24/camera/july/pd/tea-newlaunch/Launch_440x460_2._CB569410640_.png",
      "title": "Nikon Digital Camera",
      "price": 999
    },
    {
      "image": "https://m.media-amazon.com/images/I/41w9-ptS-uL._SY300_SX300_QL70_FMwebp_.jpg",
      "title": "maize",
      "price": 19000
    },
    {
      "image": "https://motorolaph.vtexassets.com/arquivos/ids/155434/motorola-edge30-pro-pdp-render-Cosmos-3-we9qp5nm.png?v=637842474822470000",
      "title": "Motorola Edge 3100 Pro",
      "price": 67000
    },
    {
      "image": "https://gppro.in/wp-content/uploads/2021/11/SONY-ILCE-A7SM3-CAMERA-GP001072-5.jpg",
      "title": "LG Cam 12 Pro",
      "price": 23000
    },
    {
      "image": "https://i.pinimg.com/736x/ce/bc/d7/cebcd741bf39058386b280fab5af1e75.jpg",
      "title": "LG V90 ThinQ",
      "price": 38000
    },
    {
      "image": "https://m.media-amazon.com/images/I/61s-3q6CYxL._AC_UY327_FMwebp_QL65_.jpg",
      "title": "KALL N9 3G Calling Tablet (2GB RAM, 16GB Storage) (Black)",
      "price": 990
    },
    {
      "image": "https://m.media-amazon.com/images/I/7185GL6hPlL._AC_UY327_FMwebp_QL65_.jpg",
      "title": "KALL N9 3G Calling Tablet (2GB RAM, 16GB Storage) (Black)",
      "price": 70990
    },
    {
      "image": "https://play-lh.googleusercontent.com/MM_V6I1jyYXEJKRwcd9-3vog3d0ir4u3meM-n4SV204dayBaeHkdkhpipC83fumaYA=w240-h480-rw",
      "title": "HD Camera 2024 for Android",
      "price": 100000
    },
    {
      "image": "https://m.media-amazon.com/images/I/41quDWydN3L._SY300_SX300_QL70_FMwebp_.jpg",
      "title": "GoPro HERO10 Black",
      "price": 27490
    },
    {
      "image": "https://cdn.mos.cms.futurecdn.net/Ekc54rx2YMgRt5ycD5KYf5.jpg",
      "title": "Canon EOS 3000D DSLR Camera 1 Body, 18 - 55 mm Lens  (Black)",
      "price": 29990
    },
    {
      "image": "https://i.pinimg.com/1200x/e7/5d/db/e75ddbda351d44e24b6b8099fa200aad.jpg",
      "title": "iphone",
      "price": 15000
    },
    {
      "image": "https://m.media-amazon.com/images/I/41m6q3pDQbL._SX300_SY300_QL70_FMwebp_.jpg",
      "title": "ASUS TUF Gaming F17 (2022)",
      "price": 70990
    },
    {
      "image": "https://m.media-amazon.com/images/I/41qGPk4nUML._SX300_SY300_QL70_FMwebp_.jpg",
      "title": "Acer [Smartchoice] Aspire Lite",
      "price": 27990
    },
    {
      "image": "https://m.media-amazon.com/images/I/41KhXf3htkL._SX300_SY300_QL70_FMwebp_.jpg",
      "title": "Samsung Galaxy Book2 (NP750)",
      "price": 64849
    }
  ]
}
