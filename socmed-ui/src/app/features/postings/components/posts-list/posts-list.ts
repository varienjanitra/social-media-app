import { Component, inject, signal } from '@angular/core';
import { PostService } from '../../services/post-service';
import { EnrichedPost, Post } from '../../data/post.model';
import { PostCard } from '../post-card/post-card';
import { UserService } from '../../../user-management/services/user-service';
import { User } from '../../../user-management/data/user.model';
import { combineLatest, map } from 'rxjs';

@Component({
  selector: 'vxsocmed-posts-list',
  imports: [
    PostCard
  ],
  templateUrl: './posts-list.html',
  styleUrl: './posts-list.scss',
})
export class PostsList {
  private postService = inject(PostService);

  postsList = signal<EnrichedPost[]>([]);

  constructor() {
    this.postService.getPosts$().subscribe(
      posts => {
        this.postsList.set(posts)
      }
    );
  }
}
