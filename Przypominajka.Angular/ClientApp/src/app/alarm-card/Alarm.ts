import { Time } from "@angular/common";

export interface AlarmCard
{
  Id: number;
  DateTime: Date,
  Note: string;
  IsPast: boolean;
  IsArchived: boolean

}
