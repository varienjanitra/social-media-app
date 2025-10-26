import { Component, inject } from '@angular/core';

import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { PostService } from '../../services/post-service';

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
  private postServices = inject(PostService);

  getPosts(): void {
    this.postServices.getPosts();
  }
}
