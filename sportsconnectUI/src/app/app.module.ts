import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PlayersListComponent } from './components/players/players-list/players-list.component';
import { EventsListComponent } from './components/events/events-list/events-list.component';
import { HttpClientModule } from '@angular/common/http';
import { AddPlayerComponent } from './components/players/add-player/add-player.component';
import { FormsModule } from '@angular/forms';
import { EditPlayerComponent } from './components/players/edit-player/edit-player.component';
import { EditEventComponent } from './components/events/edit-event/edit-event.component';
import { AddEventComponent } from './components/events/add-event/add-event.component';
import { OverviewComponent } from './components/overview/overview.component';

@NgModule({
  declarations: [
    AppComponent,
    PlayersListComponent,
    EventsListComponent,
    AddPlayerComponent,
    EditPlayerComponent,
    EditEventComponent,
    AddEventComponent,
    OverviewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
