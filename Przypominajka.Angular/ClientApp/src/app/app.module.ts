import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { RouterModule, Routes, ExtraOptions } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';

import { DecimalPipe } from '@angular/common';
import { DatePipe } from '@angular/common';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AlarmCardComponent } from './alarm-card/alarm-card.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { AlarmInfosCardComponent } from './alarm-infos-card/alarm-infos-card.component';

const appRoutes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'alarm-card', component: AlarmCardComponent },
  { path: 'alarmInfosCard/:Id', component: AlarmInfosCardComponent },
];

const routingOptions: ExtraOptions = {
  onSameUrlNavigation: 'reload',
};

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AlarmInfosCardComponent,
    AlarmCardComponent,
    NavMenuComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(appRoutes, routingOptions),
    NoopAnimationsModule,
  ],
  providers: [

  ],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class AppModule { }

