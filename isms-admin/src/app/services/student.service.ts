import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BaseService } from './base.service';
import { StudentRowIndexModel } from '../models/student/student-row-index.model';
import { StudentDetail } from '../models/student/student-detail';

@Injectable({
  providedIn: 'root'
})
export class StudentService extends BaseService{

  constructor( private http: HttpClient) {
    super("Student");
   }
   
    async getAll() {
      let _res:any = await this.http.get(this.action("GetAll")).toPromise();
      return _res.map(x => new StudentRowIndexModel(x));
    }
    async getById( id ){
      let _res:any = await this.http.get(this.action("GetById", id)).toPromise();
      return new StudentDetail(_res);
    }
}
