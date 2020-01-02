import { Component, OnInit } from '@angular/core';
import { Select2OptionData } from 'ng-select2';

@Component({
  selector: 'app-event-detail',
  templateUrl: './event-detail.component.html',
  styleUrls: ['./event-detail.component.scss']
})
export class EventDetailComponent implements OnInit {
  private exampleData: Array<Select2OptionData> ;
  private ckConfig = {
    toolbar: ['ckfinder'],
    ckfinder: {
      options: {
        resourceType: 'Images'
      },
      uploadUrl: 'http://localhost:4200/test/upload/iamge'
     }
    }    

  constructor() { }

  ngOnInit() {
    this.exampleData = [
      {
        id: 'opt1',
        text: 'Options 1'
      },
      {
        id: 'opt2',
        text: 'Options 2'
      },
      {
        id: 'opt3',
        text: 'Options 3'
      },
      {
        id: 'opt4',
        text: 'Options 4'
      }
    ];
  }

}
