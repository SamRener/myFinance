import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService<T> {

  constructor(private _http: HttpClient) { }
  HOST = ''
  getAll = (crud: 'transactions' | 'chartOfAccount') :Observable<T[]> => this._http.get<T[]>(`${this.HOST}/api/${crud}`);
  getById = (crud: 'transactions' | 'chartOfAccount', id: number) :Observable<T> => this._http.get<T>(`${this.HOST}/api/${crud}/${id}`);
  update = (crud: 'transactions' | 'chartOfAccount', id: number, data: T) :Observable<any> => this._http.put(`${this.HOST}/api/${crud}/${id}`, data);
  insert = (crud: 'transactions' | 'chartOfAccount', data: T) :Observable<any> => this._http.put(`${this.HOST}/api/${crud}`, data);
  delete = (crud: 'transactions' | 'chartOfAccount', id: number) :Observable<any> => this._http.delete(`${this.HOST}/api/${crud}/${id}`);
}
