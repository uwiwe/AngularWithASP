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
}