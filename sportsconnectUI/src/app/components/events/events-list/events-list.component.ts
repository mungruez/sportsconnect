import { Component, OnInit, Input } from '@angular/core';
import { Event } from 'src/app/models/event.model';
import { Player } from 'src/app/models/player.model';
import { EventsService } from 'src/app/services/events.service';
import { Location } from '@angular/common';
import { Router } from '@angular/router';
@Component({
  selector: 'app-events-list',
  templateUrl: './events-list.component.html',
  styleUrls: ['./events-list.component.css']
})
export class EventsListComponent implements OnInit{
  events: Event[] =[];
  playerId: string = "";
  pCode: any;
  players: Player[] =[];
  p: any;
  constructor(private eventsService: EventsService, private router: Router, private location:Location) {
    this.p = this.location.getState();
    this.players=this.p.players;
    this.pCode=this.p.pCode;
  }

  ngOnInit(): void {
    this.eventsService.getAllEvents()
    .subscribe({
      next: (events) => {
        this.events = events;
      },
      error: (response) => {
        console.log("No Events Found: "+response);
      }
    });
  }

  joinEvent(event1: Event) {
    for (let ev of this.events) {
      if(ev.pCode==event1.pCode) {
        this.eventsService.joinEvent("/:"+this.pCode,ev).subscribe({
          next: (player) => {
            alert( "Id: "+this.pCode+" Name: "+player.name+" Phone: "+player.phone+" Joined Event: "+ev.title+" At:"+player.lastActive );
          }
        });
        this.router.navigate(['players']);
      }
    }

  }

  leaveEvent(event1: Event) {
    this.eventsService.leaveEvent("/:"+this.pCode,event1).subscribe({
      next: (player) => {
        alert( "Id: "+player.Id+" Name: "+player.name+" Phone: "+player.phone+" Has Left Event: "+event1.title+" At:"+player.lastActive );
      }
    });
    this.router.navigate(['players']);
  }

  getEvent(event1: Event) {
    alert( "Id: "+event1.pCode+" Title: "+event1.title+" PlayersAttending: "+event1.playersAttending+" OwnerCode: "+event1.owner);
  }
}
