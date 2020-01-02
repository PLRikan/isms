import { Component, OnInit, Input } from '@angular/core';
//import { Location } from '@angular/common';
import { ActivatedRoute } from '@angular/router';
import { NewsModel } from 'src/app/models/news.models';

@Component({
  selector: 'app-news-detail',
  templateUrl: './news-detail.component.html',
  styleUrls: ['./news-detail.component.css']
})

export class NewsDetailComponent implements OnInit {
  news: NewsModel;
  imageUrl = "../../../assets/imgs/";
  constructor(
    private activatedRoute: ActivatedRoute
  ) { }

  ngOnInit() {
  }
}
