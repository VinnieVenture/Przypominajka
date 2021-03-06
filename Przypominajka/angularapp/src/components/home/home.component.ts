import { Component } from '@angular/core';
import { ButtonModule } from 'primeng/primeng';
import { AlarmCard } from '../alarm-card/Alarm';
import { Alarms } from '../exampleAlarms'

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent {
  list = Alarms;


}
