import { Component, OnInit } from '@angular/core';
import { Player } from 'src/app/models/player.model';
import { PlayersService } from 'src/app/services/players.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  players: Player[] =[];
  title = 'sportsconnectUI';

  constructor(private playersService: PlayersService) {}

  ngOnInit(): void {
    this.playersService.getAllPlayers()
    .subscribe({
      next: (players) => {
        this.players=players;
      },
      error: (response) => {
        console.log("No Connection"+response.error);
      }
    });
  }
}
