import { Component, OnInit } from '@angular/core';
import { ActivatedRoute} from '@angular/router';

@Component({
  selector: 'app-event-detail',
  templateUrl: './event-detail.component.html',
  styleUrls: ['./event-detail.component.css']
})
export class EventDetailComponent implements OnInit {
  idEvent: number;
  constructor(private activatedRoute: ActivatedRoute) { }

  ngOnInit() {
    this.idEvent = +this.activatedRoute.snapshot.paramMap.get('id');
  }

}
