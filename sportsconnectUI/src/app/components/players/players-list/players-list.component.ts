import { Component, OnInit } from '@angular/core';
import { Player } from 'src/app/models/player.model';
import { PlayersService } from 'src/app/services/players.service';

@Component({
  selector: 'app-players-list',
  templateUrl: './players-list.component.html',
  styleUrls: ['./players-list.component.css']
})
export class PlayersListComponent implements OnInit{
  players: Player[] =[];

  constructor(private playersService: PlayersService) {}

  ngOnInit(): void {
    this.playersService.getAllPlayers()
    .subscribe({
      next: (players) => {
        this.players=players;
      },
      error: (response) => {
        alert("No Connection :"+response.error);
      }
    });
  }

  getPlayer(playerCode: number) {
    this.playersService.getPlayer(playerCode+"")
    .subscribe({
      next: (player) => {
        alert( "ID: "+player.pCode+"  NAME: "+player.name+"  AGE: "+player.age+" ADDRESS: "+player.address+" EVENTS_ATTENDING: "+player.attending);
      }
    });
  }
 }
