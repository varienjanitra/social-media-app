import { Component } from '@angular/core';
import { PostCard } from '../../features/postings/components/post-card/post-card';

@Component({
  selector: 'vxsocmed-home',
  imports: [
    PostCard
  ],
  templateUrl: './home.page.html',
  styleUrl: './home.page.scss',
})
export class HomePage {

}
