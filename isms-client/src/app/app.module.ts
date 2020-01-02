import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FooterComponent } from './component/layout/footer/footer.component';
import { HeaderComponent } from './component/layout/header/header.component';
import { OtherPostComponent } from './component/other-post/other-post.component';
import { AboutComponent } from './component/about/about.component';
import { ContactsComponent } from './component/contacts/contacts.component';
import { HomeComponent } from './component/home/home.component';
import { NewsComponent } from './component/news/news/news.component';
import { NewsDetailComponent } from './component/news/news-detail/news-detail.component';
import { EventComponent } from './component/events/event/event.component';
import { EventCardComponent } from './component/events/event-card/event-card.component';
import { EventDetailComponent } from './component/events/event-detail/event-detail.component';
import { SlidersComponent } from './component/layout/sliders/sliders.component';
import { UserLayoutComponent } from './component/layout/user-layout/user-layout.component';
import { AdHeaderComponent } from './admin/component/layout/ad-header/ad-header.component';
import { AdminLayoutComponent } from './admin/component/layout/admin-layout/admin-layout.component';
import { AdHomeComponent } from './admin/component/ad-home/ad-home.component';
import { AdNewsComponent } from './admin/component/ad-news/ad-news.component';
import { AdEventsComponent } from './admin/component/ad-events/ad-events.component';
import { AdStudentsComponent } from './admin/component/ad-students/ad-students.component';
import { BigvideoComponent } from './component/layout/bigvideo/bigvideo.component';
import { BannerComponent } from './component/layout/banner/banner.component';


@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    HeaderComponent,
    OtherPostComponent,
    AboutComponent,
    ContactsComponent,
    HomeComponent,
    NewsComponent,
    NewsDetailComponent,
    EventComponent,
    EventCardComponent,
    EventDetailComponent,
    SlidersComponent,
    UserLayoutComponent,
    AdHeaderComponent,
    AdminLayoutComponent,
    AdHomeComponent,
    AdNewsComponent,
    AdEventsComponent,
    AdStudentsComponent,
    BigvideoComponent,
    BannerComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
