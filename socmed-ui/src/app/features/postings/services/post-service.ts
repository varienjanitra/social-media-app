import { inject, Injectable } from '@angular/core';
import { EnrichedPost, Post } from '../data/post.model';
import { HttpClient } from '@angular/common/http';
import { combineLatest, map, Observable } from 'rxjs';
import { UserService } from '../../user-management/services/user-service';

@Injectable({
  providedIn: 'root'
})
export class PostService {

  private httpService = inject(HttpClient);
  private userService = inject(UserService);

  baseUrl = 'http://localhost:5077';

  getPosts$(): Observable<EnrichedPost[]> {
    const posts$ = this.httpService.get<Post[]>(this.baseUrl + '/Posts');
    const users$ = this.userService.getUsers$();

    return combineLatest([posts$, users$])
      .pipe(
        map(([posts, users]) => {
          const userMap = new Map<number, string>();
          users.forEach(user => {
            userMap.set(user.id, user.username);
          });

          return posts.map(post => {
            const userName = userMap.get(post.postedByUserId) || 'Unknown User';

            return {
              ...post,
              userName: userName,
            } as EnrichedPost;
          });
        })
      )
  }

  createNewPost(newPost: Post): void {

  }
}
