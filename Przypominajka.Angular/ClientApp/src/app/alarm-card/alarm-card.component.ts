import { Component, Input, OnInit } from '@angular/core';
import { AlarmCard } from './Alarm';

@Component({
  selector: 'alarm-card',
  templateUrl: './alarm-card.component.html',
  styleUrls: ['./alarm-card.component.css']
})
export class AlarmCardComponent implements OnInit {

  constructor() { }

  @Input()
  alarm: AlarmCard;

  date: string;
  time: string;

  ngOnInit() {
    this.date = this.alarm.DateTime.toLocaleDateString(); 

    this.time = this.alarm.DateTime.getHours().toString() + ":" + this.alarm.DateTime.getMinutes().toString();
  }

}
