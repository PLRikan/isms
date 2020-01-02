import { Component, OnInit } from '@angular/core';
import { StudentRowIndexModel } from './../../models/student/student-row-index.model';
import { StudentService } from './../../services/student.service';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.scss']
})
export class StudentsComponent implements OnInit {
  private StudentList: Array<StudentRowIndexModel>;
  private tmp:number;

  constructor( private service: StudentService) { }

  async ngOnInit() {
    this.tmp=10;
    this.StudentList = await this.service.getAll();
    this.xuat();
  }
  xuat(){
    console.log(this.StudentList);
  }
}
