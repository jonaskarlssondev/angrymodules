# Dockerfile for development

from node:18-alpine as node

WORKDIR /app

ADD package.json /app

RUN npm i --silent

ADD . /app

RUN npm run build 

CMD npm start