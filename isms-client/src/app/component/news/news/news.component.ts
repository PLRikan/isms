import { Component, OnInit, OnDestroy } from '@angular/core';
import { PostsService } from 'src/app/services/posts.service';
import { NewsModel } from 'src/app/models/news.models';
import {Subscription} from 'rxjs';

@Component({
  selector: 'app-news',
  templateUrl: './news.component.html',
  styleUrls: ['./news.component.css']
})
export class NewsComponent implements OnInit, OnDestroy {
  imageUrl = '../../../assets/imgs/';
  News: NewsModel[];
  public subscription : Subscription;
  constructor(private service : PostsService) { }

  ngOnInit() {
      //  get
      //  this.service.getAll().subscribe(x=>{
      //    console.log(x)
      //  })
      //  get + id
      //  this.service.getById(1).subscribe(x=>{
      //    console.log(x)
      //  })
      //  Post + number | string | bool...
      //  this.service.search("ASD").subscribe(x=>{
      //    console.log(x)
      //  })
      //  Post + Object
      // this.service.getByDate(new Date("12/20/2019"),new Date("12/31/2019")).subscribe(x => {
      //   console.log(x)
      // })
      this.subscription = this.service.getAll().subscribe(data => {
        console.log(this.News = data);
      }, err => {
        this.service.handleError(err);
      });
    }
    ngOnDestroy() {
      if(this.subscription){
        this.subscription.unsubscribe();
      }
    }
}
