import { Location } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Data } from '@angular/router';

@Component({
  selector: 'alarm-infos-card',
  templateUrl: './alarm-infos-card.component.html',
  styleUrls: ['./alarm-infos-card.component.css']
})
export class AlarmInfosCardComponent implements OnInit {

  Id: number;
  paramsSub: any;
  DateTime: Data;
  Note: string;

  constructor(private activatedRoute: ActivatedRoute, private location: Location) { }

  ngOnInit() {
    this.paramsSub = this.activatedRoute.params.subscribe(params =>
      this.Id = parseInt(params['Id'], 10)
    )
    this.LoadData();
  }

  ngOnDestroy()
  {
    this.paramsSub.unsubscribe();
  }

  LoadData()
  {
    this.DateTime = new Date();
    this.Note = "Alarm /n/nAlarm!"
  }
}
