/* These commands shall be run on first of database creation */

CREATE TABLE users (
    id BIGSERIAL PRIMARY KEY,
    username TEXT NOT NULL UNIQUE
);

CREATE TABLE posts (
    id BIGSERIAL PRIMARY KEY,
    posted_by_user_id BIGINT REFERENCES users (id) NOT NULL,
    post_body TEXT NOT NULL,
    date_created TIMESTAMP WITH TIME ZONE DEFAULT CURRENT_TIMESTAMP
);
