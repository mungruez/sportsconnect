import { Component, OnInit } from '@angular/core';
import { Player } from 'src/app/models/player.model';
import { PlayersService } from 'src/app/services/players.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-add-player',
  templateUrl: './add-player.component.html',
  styleUrls: ['./add-player.component.css']
})
export class AddPlayerComponent implements OnInit{

  addPlayerRequest: Player = {
    Id: 'dbcc7c95-a758-426f-bd87-88633e852b07',
    name: '',
    age: 0,
    sport: '',
    phone: '',
    address: '',
    lastActive: new Date(Date.now()),
    attending: 'NA',
    pCode: 0
   };

  constructor(private playerService: PlayersService, private router: Router) 
  { }
  
  ngOnInit(): void {
    console.log(this.addPlayerRequest);
  }

  addPlayer() {
    this.addPlayerRequest.lastActive=new Date(Date.now());
    this.addPlayerRequest.attending="NoEvents";
    this.addPlayerRequest.Id='dbcc7c95-a758-426f-bd87-88633e852b07';
    this.addPlayerRequest.pCode=19;
    
    this.playerService.addPlayer(this.addPlayerRequest)
    .subscribe({
      next: (playerId) => {
        this.router.navigate(['players']);
      },
      error: (response) => {
        alert("Error: "+response.status+" "+response.body);
        console.log(response);
      }
    })
  }
}
