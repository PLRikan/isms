import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { UserLayoutComponent } from './component/layout/user-layout/user-layout.component';
import { AdminLayoutComponent } from './admin/component/layout/admin-layout/admin-layout.component';

//import for USER
import { HomeComponent } from './component/home/home.component';
import { NewsComponent } from './component/news/news/news.component';
import { NewsDetailComponent } from './component/news/news-detail/news-detail.component';
import { EventComponent } from './component/events/event/event.component';
import { EventCardComponent } from './component/events/event-card/event-card.component';
import { EventDetailComponent } from './component/events/event-detail/event-detail.component';
import { ContactsComponent } from './component/contacts/contacts.component';
import { AboutComponent } from './component/about/about.component';

//import for ADMIN
import { AdHomeComponent } from './admin/component/ad-home/ad-home.component';
import { AdStudentsComponent } from './admin/component/ad-students/ad-students.component';


const routes: Routes = [
  {
    path: '', component: UserLayoutComponent, children:[
      { path: '', component: HomeComponent },
      { path: 'home', component: HomeComponent },
      { path: 'news' , component: NewsComponent },
      { path: 'news/detail/:id', component: NewsDetailComponent },
      { path: 'events', component:  EventComponent },
      { path: 'events/eventcard', component: EventCardComponent },
      { path: 'events/detail/:id', component: EventDetailComponent },  
      { path: 'contact', component: ContactsComponent },
      { path: 'aboutus', component: AboutComponent },
      //{ path: 'acount/register'}
      //{ path: 'acount/login' }
      //{ paht: 'acount/detail' }
      //{ path: 'acoutn/edit' }
      //{ path: 'acount/logout' }
    ]
  },
  {
    path: '', component: AdminLayoutComponent, children:[
      { path: 'admin', component: AdHomeComponent},
      { path: 'admin/students', component: AdStudentsComponent }  
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
