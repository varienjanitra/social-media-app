import { Component } from '@angular/core';
import { PostCard } from '../../features/postings/components/post-card/post-card';
import { PostEditor } from "../../features/postings/components/post-editor/post-editor";
import { PostsList } from "../../features/postings/components/posts-list/posts-list";

@Component({
  selector: 'vxsocmed-home',
  imports: [
    PostEditor,
    PostsList
],
  templateUrl: './home.page.html',
  styleUrl: './home.page.scss',
})
export class HomePage {

}
