import { Component } from '@angular/core';
import { PostsCard } from '../../features/postings/components/posts-card/posts-card';

@Component({
  selector: 'vxsocmed-home',
  imports: [
    PostsCard
  ],
  templateUrl: './home.page.html',
  styleUrl: './home.page.scss',
})
export class HomePage {

}
