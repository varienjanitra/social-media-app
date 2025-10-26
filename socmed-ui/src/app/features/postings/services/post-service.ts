import { inject, Injectable, signal } from '@angular/core';
import { Post } from '../data/post.model';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PostService {

  private httpService = inject(HttpClient);

  baseUrl = 'http://localhost:5077';

  getPosts(): Observable<Post[]> {
    return this.httpService.get<Post[]>(this.baseUrl + '/Posts')
  }

  createNewPost(newPost: Post): void {

  }
}
