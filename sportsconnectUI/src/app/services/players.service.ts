import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Player } from '../models/player.model'; 
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
@Injectable({
  providedIn: 'root'
})
export class PlayersService {

  baseapiurl: string = environment.baseApiUrl;
  constructor(private http: HttpClient) { }

  getAllPlayers() : Observable<Player[]> {
    return this.http.get<Player[]>(this.baseapiurl + '/api/Player');
  }

  addPlayer(addPlayerRequest: Player) :Observable<Player> {
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type':  'application/json'
      })
    };
  
    return this.http.post<Player>(this.baseapiurl+'/api/Player/', addPlayerRequest, httpOptions);
  }

  getPlayer(id: string) :Observable<Player> {
    return this.http.get<Player>(this.baseapiurl+'/api/Player/'+id);
  }

  updatePlayer(id: string, updatePlayerRequest: Player) :Observable<Player> {
    return this.http.put<Player>(this.baseapiurl+'/api/Player/'+id, updatePlayerRequest);
  }

  deletePlayer(id: string) :Observable<Player> {
    return this.http.delete<Player>(this.baseapiurl+'/api/Player/'+id);
  }
}
