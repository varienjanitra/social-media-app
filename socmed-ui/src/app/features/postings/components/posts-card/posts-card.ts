import { Component } from '@angular/core';

import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';

@Component({
  selector: 'vxsocmed-posts-card',
  imports: [
    MatCardModule,
    MatButtonModule
  ],
  templateUrl: './posts-card.html',
  styleUrl: './posts-card.scss',
})
export class PostsCard {

}
