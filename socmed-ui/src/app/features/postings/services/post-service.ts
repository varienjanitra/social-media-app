import { inject, Injectable } from '@angular/core';
import { Post } from '../data/post.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PostService {

  httpService = inject(HttpClient);

  createNewPost(newPost: Post): void {

  }
}
