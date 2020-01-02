import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {NgReduxModule} from '@angular-redux/store';
import {NgRedux, DevToolsExtension} from '@angular-redux/store';
import {rootReducer, ArchitectUIState} from 'src/app/static/ThemeOptions/store';
import {ConfigActions} from 'src/app/static/ThemeOptions/store/config.actions';
import {AppRoutingModule} from './app-routing.module';
import {LoadingBarRouterModule} from '@ngx-loading-bar/router';
import { NgSelect2Module } from 'ng-select2';

import {CommonModule} from '@angular/common';
import {HttpClientModule} from '@angular/common/http';
import {AppComponent} from './app.component';

// BOOTSTRAP COMPONENTS

import {AngularFontAwesomeModule} from 'angular-font-awesome';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import {PerfectScrollbarModule} from 'ngx-perfect-scrollbar';
import {PERFECT_SCROLLBAR_CONFIG} from 'ngx-perfect-scrollbar';
import {PerfectScrollbarConfigInterface} from 'ngx-perfect-scrollbar';
// LAYOUT

import {BaseLayoutComponent} from './layouts/base-layout/base-layout.component';
import {PagesLayoutComponent} from './layouts/pages-layout/pages-layout.component';
import {PageTitleComponent} from './layouts/base-layout/page-title/page-title.component';

// HEADER

import {HeaderComponent} from './layouts/base-layout/header/header.component';
import {SearchBoxComponent} from './layouts/base-layout/header/elements/search-box/search-box.component';
import {UserBoxComponent} from './layouts/base-layout/header/elements/user-box/user-box.component';
import {UserImageComponent} from './layouts/base-layout/header/elements/user-image/user-image.component';

// SIDEBAR

import {SidebarComponent} from './layouts/base-layout/sidebar/sidebar.component';
import {LogoComponent} from './layouts/base-layout/sidebar/elements/logo/logo.component';

// FOOTER

import {FooterComponent} from './layouts/base-layout/footer/footer.component';

// DEMO PAGES
import { EventComponent } from './components/Events/event-list/event.component';
import { IconsComponent } from './components/Elements/icons/icons.component';
import { EventService } from './services/event.service';
import { StudentsComponent } from './components/students/students.component';
import { StudentDetailComponent } from './components/students/student-detail/student-detail.component';
import { LecturersComponent } from './components/lecturers/lecturers.component';
import { LecturerDetailComponent } from './components/lecturers/lecturer-detail/lecturer-detail.component';
import { EventDetailComponent } from './components/Events/event-detail/event-detail.component';
import { AdminsComponent } from './components/admins/admins.component';
import { AdminDetailComponent } from './components/admins/admin-detail/admin-detail.component';

const DEFAULT_PERFECT_SCROLLBAR_CONFIG: PerfectScrollbarConfigInterface = {
  suppressScrollX: true
};

@NgModule({
  declarations: [
    // LAYOUT

    AppComponent,
    BaseLayoutComponent,
    PagesLayoutComponent,
    PageTitleComponent,

    // HEADER

    HeaderComponent,
    SearchBoxComponent,
    UserBoxComponent,
    UserImageComponent,

    // SIDEBAR

    SidebarComponent,
    LogoComponent,

    // FOOTER

    FooterComponent,

    // PAGE

    EventComponent,
    IconsComponent,
    StudentsComponent,
    StudentDetailComponent,
    LecturersComponent,
    LecturerDetailComponent,
    EventDetailComponent,

    AdminsComponent,
    AdminDetailComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    NgReduxModule,
    CommonModule,
    LoadingBarRouterModule,

    // Angular Bootstrap Components

    PerfectScrollbarModule,
    NgbModule,
    AngularFontAwesomeModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgSelect2Module
  ],
  providers: [
    {
      provide:
      PERFECT_SCROLLBAR_CONFIG,
      // DROPZONE_CONFIG,
      useValue:
      DEFAULT_PERFECT_SCROLLBAR_CONFIG,
      // DEFAULT_DROPZONE_CONFIG,
    },
    ConfigActions,
    EventService
  ],
  bootstrap: [AppComponent]
})

export class AppModule {
  constructor(private ngRedux: NgRedux<ArchitectUIState>,
              private devTool: DevToolsExtension) {

    this.ngRedux.configureStore(
      rootReducer,
      {} as ArchitectUIState,
      [],
      [devTool.isEnabled() ? devTool.enhancer() : f => f]
    );

  }
}
