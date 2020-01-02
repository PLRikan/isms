import { Component, OnInit } from '@angular/core';
import { EventService } from 'src/app/services/event.service';
import { EventModel } from 'src/app/models/event/event.model';

@Component({
  selector: 'app-event',
  templateUrl: './event.component.html',
  styleUrls: ['./event.component.css']
})
export class EventComponent implements OnInit {

  private eventList: Array<EventModel>;

  constructor(private eventService: EventService) {
  }

  async ngOnInit() {
    this.eventList = await this.eventService.getAll();
    console.log("finish-loading")
  }
}
