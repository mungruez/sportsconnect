import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Event } from '../models/event.model';
import { Player } from '../models/player.model'; 
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
@Injectable({
  providedIn: 'root'
})
export class EventsService {

  baseapiurl: string = environment.baseApiUrl;
  constructor(private http: HttpClient) { }

  getAllEvents() : Observable<Event[]> {
    return this.http.get<Event[]>(this.baseapiurl + '/api/Event');
  }

  addEvent(addEventRequest: Event) :Observable<Event> {
    addEventRequest.Id='dbcc7c95-a758-426f-bd87-88633e852b07';
    return this.http.post<Event>(this.baseapiurl + '/api/Event', addEventRequest);
  }

  getEvent(id: string) :Observable<Event> {
    return this.http.get<Event>(this.baseapiurl+'/api/Event/'+id);
  }

  updateEvent(id: string, updateEventRequest: Event) :Observable<Event> {
    return this.http.put<Event>(this.baseapiurl+'/api/Event/'+id, updateEventRequest);
  }

  deleteEvent(id: string) :Observable<Event> {
    return this.http.delete<Event>(this.baseapiurl+'/api/Event/'+id);
  }

  joinEvent(id: string, joinEventRequest: Event) :Observable<Player> {
    return this.http.put<Player>(this.baseapiurl+'/api/Event/Join'+id, joinEventRequest);
  }

  leaveEvent(id: string, leaveEventRequest: Event) :Observable<Player> {
    return this.http.put<Player>(this.baseapiurl+'/api/Event/Leave'+id, leaveEventRequest);
  }  
}
