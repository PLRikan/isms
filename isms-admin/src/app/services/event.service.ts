import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { BaseService } from './base.service';
import { EventModel } from '../models/event/event.model';
import { map, catchError } from 'rxjs/operators';
import { Observable, throwError } from 'rxjs';


@Injectable({
    providedIn: 'root'
})
export class EventService extends BaseService {
    constructor(private http: HttpClient) {
        super("Event");
    }
    async getAll() {
        let _res:any = await this.http.get(this.action("GetAll")).toPromise();
        return _res.map(x => new EventModel(x));
    }
    async getById(id) {
        let _res =await this.http.get(this.action("GetById",id)).toPromise();
        return new EventModel(_res);
    }
}