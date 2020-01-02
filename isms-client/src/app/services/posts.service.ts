import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { NewsModel } from '../models/news.models';
import { Observable, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PostsService {
  baseUrl = environment.apiUrl;
  // private url: string;
  // public table: string;
  constructor(private http: HttpClient) {
    // this.table = '/Post/';
    // this.url = environment.apiUrl + this.table;
  }

  getAll(): Observable<NewsModel[]>{
    return this.http.get<NewsModel[]>(this.baseUrl + '/post/getall');
  }
  getById(id : number): Observable<NewsModel[]>{
    return this.http.get<NewsModel[]>(this.baseUrl + '/post/GetById/' + id);
  }
  getNews(page: number): Observable<NewsModel[]>{
    return this.http.get<NewsModel[]>(this.baseUrl + '/post/News/' + page);
  }
  handleError(error) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
        // client-side error
        errorMessage = `Error: ${error.error.message}`;
    } else {
        // server-side error
        errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    console.log(errorMessage);
    return throwError(errorMessage);
  }

  // public getAll() {
  //   return this.http.get(this.url + 'GetAll', {observe: 'response'});
  // }
  // //////////////////
  // public getById(id: number) {
  //   return this.http.get(this.url + 'GetById/' + id);
  // }
  // public getNews(page: number) {
  //   return this.http.get(this.url + 'News/' + page);
  // }
  // public search(title: string) {
  //   const body = title
  //   return this.http.post<string>(this.url + 'GetByTitle' , body);
  // }
  // public getByDate(from: Date, to: Date){
  //   let body = {
  //     'fromDate': from,
  //     'toDate': to
  //   }
  //   return this.http.post<string>(this.url + 'GetByDate', body);
  // }
}
