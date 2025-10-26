import { Component } from '@angular/core';

import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';

@Component({
  selector: 'vxsocmed-posts-card',
  imports: [
    MatCardModule,
    MatButtonModule
  ],
  templateUrl: './post-card.html',
  styleUrl: './post-card.scss',
})
export class PostCard {

}
