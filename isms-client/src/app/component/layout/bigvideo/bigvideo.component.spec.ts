import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BigvideoComponent } from './bigvideo.component';

describe('BigvideoComponent', () => {
  let component: BigvideoComponent;
  let fixture: ComponentFixture<BigvideoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BigvideoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BigvideoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
