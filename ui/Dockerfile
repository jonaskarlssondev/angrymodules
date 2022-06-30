from node:18-alpine as node
EXPOSE 80

WORKDIR /app
COPY . .
RUN npm install
RUN npm run build --prod

FROM nginx:alpine
COPY --from=node /app/dist/ui /usr/share/nginx/html
CMD ["nginx", "-g", "daemon off;"]