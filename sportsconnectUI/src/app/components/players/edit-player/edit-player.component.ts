import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { PlayersService } from 'src/app/services/players.service';
import { Player } from 'src/app/models/player.model';
@Component({
  selector: 'app-edit-player',
  templateUrl: './edit-player.component.html',
  styleUrls: ['./edit-player.component.css']
})
export class EditPlayerComponent implements OnInit {
  playerDetails: Player = {
    Id: 'dbcc7c95-a758-426f-bd87-88633e852b07',
    name: '',
    age: 0,
    sport: '',
    phone: '',
    address: '',
    lastActive: new Date(Date.now()),
    attending: '',
    pCode: 0
  };

  constructor(private route: ActivatedRoute, private playerService :PlayersService, private router: Router) {
  }
  
  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const pCode = params.get('pCode')

        if(pCode) {
          this.playerDetails.lastActive=new Date(Date.now());
          this.playerDetails.Id='dbcc7c95-a758-426f-bd87-88633e852b07';
          this.playerDetails.pCode=Number.parseInt(pCode);
          this.playerService.getPlayer(pCode+"")
          .subscribe({
            next: (response) => {
              this.playerDetails = response;
            }
          });
        }
      }
    })
  }  

  updatePlayer() {
    this.playerService.updatePlayer(this.playerDetails.pCode+"", this.playerDetails)
    .subscribe({
      next: (player) => {
        this.router.navigate(['players']);
      }
    });
  }

  deletePlayer() {
    this.playerService.deletePlayer(this.playerDetails.pCode+"")
    .subscribe({
      next: (response) => {
        this.router.navigate(['players']);
      }
    });
  }
}
