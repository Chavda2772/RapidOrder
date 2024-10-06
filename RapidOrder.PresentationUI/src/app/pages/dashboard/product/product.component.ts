import { Component, Input } from '@angular/core';
import { Configs } from '../../../core/constant/Configs'

@Component({
  selector: 'app-product',
  standalone: true,
  imports: [],
  templateUrl: './product.component.html',
  styleUrl: './product.component.scss'
})
export class ProductComponent {
  @Input() image = "";
  @Input() title = "";
  @Input() price = 20;

  symbol = Configs.currencySymbol;
}
