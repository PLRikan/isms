import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdEventsComponent } from './ad-events.component';

describe('AdEventsComponent', () => {
  let component: AdEventsComponent;
  let fixture: ComponentFixture<AdEventsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdEventsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdEventsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
