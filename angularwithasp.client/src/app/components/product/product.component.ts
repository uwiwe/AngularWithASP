import { Component, Input } from '@angular/core';
import { Product } from './../../models/product.model';

@Component({
  standalone: true, //nuevo, los dos componentes deben ser standalone
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {

  @Input() product!: Product;

}
