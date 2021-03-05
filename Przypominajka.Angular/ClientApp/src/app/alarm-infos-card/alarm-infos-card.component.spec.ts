import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AlarmInfosCardComponent } from './alarm-infos-card.component';

describe('AlarmInfosCardComponent', () => {
  let component: AlarmInfosCardComponent;
  let fixture: ComponentFixture<AlarmInfosCardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AlarmInfosCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AlarmInfosCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
