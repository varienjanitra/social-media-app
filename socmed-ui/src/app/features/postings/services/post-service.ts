import { inject, Injectable, signal } from '@angular/core';
import { Post } from '../data/post.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PostService {

  private httpService = inject(HttpClient);
  postsList = signal<Post[]>([]);

  baseUrl = 'http://localhost:5077';

  getPosts(): void {
    this.httpService.get(this.baseUrl + '/Posts').subscribe(
      posts => {
        console.log(posts);
      }
    )
  }

  createNewPost(newPost: Post): void {

  }
}
