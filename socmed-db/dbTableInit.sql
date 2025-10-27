/* These commands shall be run after database first creation 'dbCreation.sql' to populate database */

INSERT INTO users (username)
VALUES
('vx-socmed-superuser'),
('varien');

INSERT INTO posts (posted_by_user_id, post_body)
VALUES
(2, 'Just dropped my new fall playlist on Spotify, link in bio! 🎧🍂 Vibe check: certified cozy. #NewMusic #AutumnAesthetic'),
(2, 'Seriously cannot believe how good this new coffee shop is. Their lavender latte is iconic. ☕️💜 Rate my study spot! 👇'),
(2, 'Ate the leftovers I packed for lunch and forgot to take a picture of my fit check this morning. 😩 It was fire, though. Trust me. 😂'),
(2, 'Did anyone else catch the comet last night? The pics don''t even do it justice! Nature is wild, y''all. 🌌✨'),
(2, 'Pro-tip: always proofread your code before pushing to main. Saved myself a massive headache just now. 😵‍💻 Lesson learned. #devlife');