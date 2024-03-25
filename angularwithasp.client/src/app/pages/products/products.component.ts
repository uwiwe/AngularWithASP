import { Component, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ProductComponent} from './../../components/product/product.component';
import { Product } from './../../models/product.model';

@Component({
  standalone: true, //nuevo
  imports: [ ProductComponent ], //nuevo
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrl: './products.component.css'
})
export class ProductsComponent {
  
  http = inject(HttpClient); // voy a usar el httpclient es un patron de injeccion de dependencias
  products: Product[] = [];

  ngOnInit() { //Es para hacer algo con mi componente cuando ya esta renderizado
    this.http.get<Product[]>('https://api.escuelajs.co/api/v1/products') //Hacer una peticion, llamo a la api fake de platzi <Product[]> significa que va a recibir un array de Product
    .subscribe((data) => { //subscribe es algo similar a resolver una promesa. Data es un array de product, lista de productos
      this.products = data;
    });
  }
}
