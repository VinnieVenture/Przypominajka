import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AppRoutingModule } from './app-routing.module';
import { APP_BASE_HREF } from '@angular/common';
import { AlarmCardComponent } from './alarm-card/alarm-card.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AlarmCardComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [
    {
      provide: APP_BASE_HREF, useValue: '/'
    }],
  bootstrap: [AppComponent]
})
export class AppModule { }
