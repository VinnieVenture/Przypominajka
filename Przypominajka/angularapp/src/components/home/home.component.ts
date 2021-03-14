import { Component, Inject } from '@angular/core';
import { ButtonModule } from 'primeng/primeng';
import { AlarmCard } from '../alarm-card/Alarm';
import { Alarms } from '../exampleAlarms'
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { AddingNewAlarmCardComponent } from '../adding-new-alarm-card/adding-new-alarm-card.component';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent {
  list = Alarms;

  Date: Date;
  Time: Date;
  Note: string;

  constructor(public dialog: MatDialog) { }


  openDialog(): void {

    console.log('The dialog was opened');

    const dialogRef = this.dialog.open(AddingNewAlarmCardComponent, {
      width: '250px',
      data: { Date: this.Date, Time: this.Time, Note: this.Note }
    });
    console.log('asdfsafgas');

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }
}
