import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PostsCard } from './posts-card';

describe('PostsCard', () => {
  let component: PostsCard;
  let fixture: ComponentFixture<PostsCard>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PostsCard]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PostsCard);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
