import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { AlarmCard } from '../alarm-card/Alarm';
import { MatDatepickerModule } from '@angular/material/datepicker';

@Component({
  selector: 'app-adding-new-alarm-card',
  templateUrl: './adding-new-alarm-card.component.html',
  styleUrls: ['./adding-new-alarm-card.component.css']
})
export class AddingNewAlarmCardComponent implements OnInit {

  constructor(
    public dialogRef: MatDialogRef<AddingNewAlarmCardComponent>,

    @Inject(MAT_DIALOG_DATA)
    public data: AlarmCard) { }

  myFilter = (d: Date | null): boolean => { const day = (d || new Date()).getDay(); return true; };

  ngOnInit(): void {
    
  }

  onNoClick(): void {
    this.dialogRef.close();
  }
}
