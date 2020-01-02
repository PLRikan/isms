import { Component, OnInit, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs';
import { EventsService } from '../../../services/events.service';
import { EventModel } from '../../../models/event.models';
@Component({
  selector: 'app-event',
  templateUrl: './event.component.html',
  styleUrls: ['./event.component.css']
})
export class EventComponent implements OnInit, OnDestroy {
  imageUrl = "../../../assets/imgs/";
  Event: EventModel[];
  public subscription : Subscription;
  constructor(private service: EventsService) { }

  ngOnInit() {
    this.subscription = this.service.getAll().subscribe(data => {
      console.log(this.Event = data);
    },err => {
      this.service.handleError(err);
    })
  }
  ngOnDestroy() {
    if(this.subscription){
      this.subscription.unsubscribe();
    }
  }
}
