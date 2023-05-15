FROM node:16-alpine AS build
WORKDIR /app
ENV PATH /app/node_modules/.bin:$PATH
COPY package.json /app/package.json
RUN npm install
RUN npm install -g @angular/cli
RUN apk update && apk add curl
COPY . /app
CMD ng serve --host 0.0.0.0
