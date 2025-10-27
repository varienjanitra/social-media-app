import { Component, inject, input, Input } from '@angular/core';

import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';

import { EnrichedPost } from '../../data/post.model';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'vxsocmed-posts-card',
  imports: [
    MatCardModule,
    MatButtonModule,
    DatePipe
  ],
  templateUrl: './post-card.html',
  styleUrl: './post-card.scss',
})
export class PostCard {
  postData = input<EnrichedPost>();
}
