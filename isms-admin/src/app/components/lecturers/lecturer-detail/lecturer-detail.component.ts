import { Component, OnInit } from '@angular/core';
import * as $ from 'jquery';

@Component({
  selector: 'app-lecturer-detail',
  templateUrl: './lecturer-detail.component.html',
  styleUrls: ['./lecturer-detail.component.scss']
})
export class LecturerDetailComponent implements OnInit {

  constructor() { }

  ngOnInit() {
    $(".custom-file-input").on("change", function() {
      var fileName = $(this).val().split("\\").pop();
      $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
    });
  }

}
