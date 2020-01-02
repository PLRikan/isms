import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError, from } from 'rxjs';
import { EventModel } from '../models/event.models';

@Injectable({
  providedIn: 'root'
})
export class EventsService {
  baseUrl = environment.apiUrl;
  constructor(private http: HttpClient) { }
  //getAll event
  getAll() : Observable<EventModel[]>{
    return this.http.get<EventModel[]>(this.baseUrl + '/event/getall');
  }
  //get event by id
  getById(id : number) : Observable<EventModel[]>{
    return this.http.get<EventModel[]>(this.baseUrl + '/event/getbyid/' + id);
  }
  //Throw Error
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
}
