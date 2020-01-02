import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';

import {BaseLayoutComponent} from './layouts/base-layout/base-layout.component';
import {PagesLayoutComponent} from './layouts/pages-layout/pages-layout.component';
import { EventComponent } from './components/Events/event-list/event.component';
import { IconsComponent } from './components/Elements/icons/icons.component';
import { StudentsComponent } from './components/students/students.component';
import { StudentDetailComponent } from './components/students/student-detail/student-detail.component';
import { LecturersComponent } from './components/lecturers/lecturers.component';
import { LecturerDetailComponent } from './components/lecturers/lecturer-detail/lecturer-detail.component';
import { EventDetailComponent } from './components/Events/event-detail/event-detail.component';
import { AdminsComponent } from './components/admins/admins.component';
import { AdminDetailComponent } from './components/admins/admin-detail/admin-detail.component';

const routes: Routes = [
  {
    path: 'admin',
    component: BaseLayoutComponent,
    children: [
      { path: 'icons', component: IconsComponent},
      { path: 'event', children:[
        {path: '' ,component:  EventComponent},
        {path: 'detail/:id',component: EventDetailComponent}
      ]},
      { path: 'students', component: StudentsComponent },
      { path: 'students/detail/:id', component: StudentDetailComponent },
      { path: 'lecturers', component: LecturersComponent },
      { path: 'lecturers/detail', component: LecturerDetailComponent },
      { path: 'admins', component: AdminsComponent },
      { path: 'admins/detail', component: AdminDetailComponent }
    ]
  },
  {path: '**', redirectTo: 'admin'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes,
    {
      scrollPositionRestoration: 'enabled',
      anchorScrolling: 'enabled',
    })],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
