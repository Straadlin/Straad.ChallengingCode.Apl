import { Component } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { MatTableModule } from '@angular/material/table';
import { MatButtonModule } from '@angular/material/button';
import { ProductServiceService } from '../shared/product.service';
import { GetProductDto } from '../../../shared/interfaces/dto/product/get-product-dto';
import { CurrencyPipe, NgFor, UpperCasePipe } from '@angular/common';

@Component({
  selector: 'app-product-list',
  standalone: true,
  imports: [MatCardModule, MatTableModule, MatButtonModule, CurrencyPipe, UpperCasePipe, NgFor],
  templateUrl: './product-list.component.html',
  styleUrl: './product-list.component.scss'
})
export default class ProductListComponent {

  public products: GetProductDto[] = [];
  public displayedColumns: string[] = ['id', 'nombre', 'precio'];

  public constructor(private productService: ProductServiceService) {
  }

  public ngOnInit(): void {
    this.getProducts();
  }

  public getProducts(): void {
    this.productService
      .getProducts()
      .subscribe(
        (data: GetProductDto[]) => {
          this.products = data;
      }
    );
  }

  public onAddProduct(): void {
  }
}
