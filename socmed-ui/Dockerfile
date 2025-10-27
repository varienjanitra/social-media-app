FROM node:latest AS build
WORKDIR /app

COPY package.json package-lock.json ./
RUN npm install

COPY . .

RUN npm run build -- --configuration production

FROM nginx:latest
WORKDIR /usr/share/nginx/html

RUN rm -f ./*

COPY --from=build /app/dist/socmed-ui/browser/* .

COPY nginx.conf /etc/nginx/conf.d/default.configuration

EXPOSE 80
