import { HttpClient } from '@angular/common/http';
import { Component, OnInit, inject } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'eCommerce-app'
  http = inject(HttpClient); // voy a usar el httpclient
  
  changeTitle() {
    this.title = 'Nombre Cambiado';
  }
}