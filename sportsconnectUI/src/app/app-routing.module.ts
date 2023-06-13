import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PlayersListComponent } from './components/players/players-list/players-list.component';
import { AddPlayerComponent } from './components/players/add-player/add-player.component';
import { EditPlayerComponent } from './components/players/edit-player/edit-player.component';
import { EventsListComponent } from './components/events/events-list/events-list.component';
import { AddEventComponent } from './components/events/add-event/add-event.component';
import { EditEventComponent } from './components/events/edit-event/edit-event.component';
import { OverviewComponent } from './components/overview/overview.component';
const routes: Routes = [
  {
    path: '',
    component: PlayersListComponent
  },
  {
    path: 'players',
    component: PlayersListComponent 
  },
  {
    path: 'players/add',
    component: AddPlayerComponent 
  },
  {
    path: 'players/edit/:pCode',
    component: EditPlayerComponent 
  },
  {
    path: 'events',
    component: EventsListComponent 
  },
  {
    path: 'events/add',
    component: AddEventComponent 
  },
  {
    path: 'events/edit/:pCode',
    component: EditEventComponent 
  },
  {
    path: 'overview',
    component: OverviewComponent 
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
