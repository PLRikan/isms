import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import {} from '../models/contacts.models';

@Injectable({
  providedIn: 'root'
})
export class ContactsService {
  baseUrl = environment.apiUrl;
  constructor(private http:HttpClient) { }

  
}
