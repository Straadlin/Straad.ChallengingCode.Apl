import { inject, Injectable } from '@angular/core';
import { GetProductDto } from '../../../shared/interfaces/dto/product/get-product-dto';
import { Observable, timeout } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductServiceService {

  private http = inject(HttpClient);
  private timeout = 60000; // 60

  constructor() {
  }

  public getProducts(): Observable<GetProductDto[]> {
    return this.http
    .get<GetProductDto[]>('https://localhost:7023/api/Products')
    .pipe(
      timeout(this.timeout)
    );
  }
}
