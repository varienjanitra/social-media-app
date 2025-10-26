import { Component, inject, signal } from '@angular/core';
import { PostService } from '../../services/post-service';
import { Post } from '../../data/post.model';
import { PostCard } from '../post-card/post-card';

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

  postsList = signal<Post[]>([]);

  constructor() {
    this.postService.getPosts$().subscribe(
      posts => {
        this.postsList.set(posts)
      }
    );
  }
}
