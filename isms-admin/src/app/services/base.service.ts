import { environment } from 'src/environments/environment';
import { EventModel } from '../models/event/event.model';
import { HttpClient } from '@angular/common/http';

export class BaseService {
    private _url: string;

    get url() {
        return this._url;
    }

    private _table: string;

    get table() {
        return this._table;
    }

    protected action(...str: string[]) {
        let _str:string = str.join('/');
        return this.url + "/" + _str;
    }

    constructor(table: string) {
        this._table = table;
        // https://localhost:5001/Post
        if (environment.apiUrl.slice(-1) != "/")
            environment.apiUrl = environment.apiUrl + '/';
        this._url = environment.apiUrl + this._table;
    }
}