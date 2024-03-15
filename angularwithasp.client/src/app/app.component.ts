import { HttpClient } from '@angular/common/http';
import { Component, OnInit, inject } from '@angular/core';
import { NgOptimizedImage } from '@angular/common';
import { Product } from './models/product.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'eCommerce-app'
  http = inject(HttpClient); // voy a usar el httpclient es un patron de injeccion de dependencias
  products: Product[] = [];
  
  changeTitle() {
    this.title = 'Nombre Cambiado';
  }

  ngOnInit() { //Es para hacer algo con mi componente cuando ya esta renderizado
    this.http.get<Product[]>('https://api.escuelajs.co/api/v1/products') //Hacer una peticion, llamo a la api fake de platzi <Product[]> significa que va a recibir un array de Product
    .subscribe((data) => { //subscribe es algo similar a resolver una promesa. Data es un array de product, lista de productos
      this.products = data;
    });

  }
}