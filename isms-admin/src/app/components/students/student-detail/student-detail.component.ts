import { Component, OnInit } from '@angular/core';
import { ActivatedRoute} from '@angular/router';
import { StudentService } from '../../../services/student.service';
import { StudentDetail } from 'src/app/models/student/student-detail';
import { FormBuilder } from '@angular/forms';
import { DatePipe } from '@angular/common';
import * as $ from 'jquery';

@Component({
  selector: 'app-student-detail',
  templateUrl: './student-detail.component.html',
  styleUrls: ['./student-detail.component.scss'],
  providers: [DatePipe]
})
export class StudentDetailComponent implements OnInit { 

  id: number;
  studentDetail: StudentDetail;
  checkoutFormInfo;
  checkoutFormAcc;
  fileUpload: File;

  getFile(event){
    this.fileUpload=<File>event.target.files[0];
    console.log(this.fileUpload);
  }

  constructor(
    private service: StudentService, 
    private activatedRoute: ActivatedRoute,
    private form: FormBuilder,
    private datePipe: DatePipe
    ) {
      
     }

  async ngOnInit() {
    $("#customFile").on("change", function() {
      var fileName = $(this).val().split("\\").pop();
      $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
    });
    this.id = +this.activatedRoute.snapshot.paramMap.get('id');

    this.studentDetail = await this.service.getById(this.id);

    this.checkoutFormInfo = this.form.group({
      facultyid: this.studentDetail.facultyId,
      majorstudentid: this.studentDetail.majorStudentId,
      bankaccountid: this.studentDetail.bankAccountId,
      educatetypeid: this.studentDetail.educateTypeId,
      studytypeid: this.studentDetail.educateTypeId,
      studystatusid: this.studentDetail.studyStatusId,
      roleGroupid: this.studentDetail.roleGroupId,
      email: this.studentDetail.email,
      phonenumber: this.studentDetail.phoneNumber,
      studentcode: this.studentDetail.studentCode,
      avatar: this.studentDetail.avatar,
      fname: this.studentDetail.nameFirst,
      mname: this.studentDetail.nameMiddle,
      lname: this.studentDetail.nameLast,
      addressapartment: this.studentDetail.addressApartment,
      addressstreet: this.studentDetail.addressStreet,
      addressdistrict: this.studentDetail.addressDistrict,
      addresscity: this.studentDetail.addressCity,
      datestart: this.datePipe.transform(this.studentDetail.dateStart,'yyyy-MM-dd'),
      dateend: this.datePipe.transform(this.studentDetail.dateEnd,'yyyy-MM-dd'),
      dategraduate: this.datePipe.transform(this.studentDetail.dateGraduate,'yyyy-MM-dd')
    });
    console.log(this.studentDetail);
  };
  public updateInfo(resForm){
    console.warn(resForm);
  }
}
