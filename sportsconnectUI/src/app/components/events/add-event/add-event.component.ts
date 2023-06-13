import { Component, OnInit } from '@angular/core';
import { Event } from 'src/app/models/event.model';
import { EventsService } from 'src/app/services/events.service';
import { Router } from '@angular/router';
import { Location } from '@angular/common';
@Component({
  selector: 'app-add-event',
  templateUrl: './add-event.component.html',
  styleUrls: ['./add-event.component.css']
})
export class AddEventComponent implements OnInit{
  pCode: any;
  addEventRequest: Event = {
    Id: "dbcc7c95-a758-426f-bd87-88633e852b07",
    title: '',
    duration: 0,
    sport: '',
    owner: '',
    location: '',
    startDate: new Date(Date.now()),
    playersAttending: '',
    pCode: 0
   };

  constructor(private eventService: EventsService, private router: Router, private location:Location) 
  { 
    this.pCode = this.location.getState();
    this.addEventRequest.owner=this.pCode.pCode+"";
  }
  
  ngOnInit():void { }

  addEvent() {
    this.addEventRequest.owner=this.pCode.pCode+"";
    this.addEventRequest.playersAttending=this.pCode.pCode+",";
    this.addEventRequest.Id='dbcc7c95-a758-426f-bd87-88633e852b07';
    this.addEventRequest.pCode=19;
    this.eventService.addEvent(this.addEventRequest)
    .subscribe({
      next: (event) => {
        this.router.navigate(['events']);
      }
    });
  }
}
