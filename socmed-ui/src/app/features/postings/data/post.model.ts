export interface Post
{
  id: number,
  postedByUserId: number,
  postBody: string,
  dateCreated: Date
}

export interface EnrichedPost extends Post
{
  userName: string;
}
