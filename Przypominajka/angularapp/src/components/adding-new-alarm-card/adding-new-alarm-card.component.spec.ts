import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddingNewAlarmCardComponent } from './adding-new-alarm-card.component';

describe('AddingNewAlarmCardComponent', () => {
  let component: AddingNewAlarmCardComponent;
  let fixture: ComponentFixture<AddingNewAlarmCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddingNewAlarmCardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddingNewAlarmCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
