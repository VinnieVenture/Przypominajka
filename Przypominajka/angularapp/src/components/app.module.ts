import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { RouterModule, Routes, ExtraOptions } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { NgScrollbarModule, NG_SCROLLBAR_OPTIONS } from 'ngx-scrollbar';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { MatButtonModule } from '@angular/material/button';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AlarmCardComponent } from './alarm-card/alarm-card.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { AlarmInfosCardComponent } from './alarm-infos-card/alarm-infos-card.component';
import { AddingNewAlarmCardComponent } from './adding-new-alarm-card/adding-new-alarm-card.component';
import { MatDialogModule } from '@angular/material/dialog';
import { MatNativeDateModule } from '@angular/material/core';

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
    AddingNewAlarmCardComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(appRoutes, routingOptions),
    NoopAnimationsModule,
    NgScrollbarModule,
    MatButtonModule,
 
  ],
  exports:
    [
      MatDialogModule,
      MatNativeDateModule,
    ],
  providers: [
    
  ],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class AppModule { }

