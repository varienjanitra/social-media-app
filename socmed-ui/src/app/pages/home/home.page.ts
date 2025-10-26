import { Component } from '@angular/core';
import { PostCard } from '../../features/postings/components/post-card/post-card';
import { PostEditor } from "../../features/postings/components/post-editor/post-editor";

@Component({
  selector: 'vxsocmed-home',
  imports: [
    PostCard,
    PostEditor
],
  templateUrl: './home.page.html',
  styleUrl: './home.page.scss',
})
export class HomePage {

}
