import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EventsService } from 'src/app/services/events.service';
import { Event } from 'src/app/models/event.model';
import { Location } from '@angular/common';
import { map } from 'rxjs';
@Component({
  selector: 'app-edit-event',
  templateUrl: './edit-event.component.html',
  styleUrls: ['./edit-event.component.css']
})
export class EditEventComponent implements OnInit {
  eventId: any;
  eventDetails: Event = {
    Id: "dbcc7c95-a758-426f-bd87-88633e852b07",
    title: '',
    duration: 0,
    sport: '',
    owner: '',
    location: '',
    startDate: new Date(Date.now()),
    playersAttending: '',
    pCode: -1
  };

  constructor(private route: ActivatedRoute, private eventService :EventsService, private router: Router, private location:Location) {
    this.eventId=this.location.getState();
    this.eventDetails.owner=this.eventId.pCode+"";
    
  }
  
  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const pCode = params.get('pCode')

        if(pCode) {
          this.eventDetails.pCode=Number.parseInt(pCode);
          this.eventService.getEvent(pCode+"")
          .subscribe({
            next: (response) => {
              this.eventDetails = response;
            }
          });
        }
      }
    })
  }  

  updateEvent() {
    this.eventDetails.owner=this.eventId.pCode+"";
    this.eventDetails.playersAttending=this.eventDetails.owner+",";
    this.eventDetails.Id='dbcc7c95-a758-426f-bd87-88633e852b07';
    if (this.eventDetails.pCode<=0)
      this.eventDetails.pCode=1;
    console.log(this.eventDetails);
    this.eventService.updateEvent(this.eventDetails.pCode+"", this.eventDetails)
    .subscribe({
      next: (event) => {
        this.router.navigate(['events']);
      }
    });
  }

  deleteEvent() {
    this.eventService.deleteEvent(this.eventDetails.pCode+"")
    .subscribe({
      next: (response) => {
        this.router.navigate(['events']);
      }
    });
  }
}
