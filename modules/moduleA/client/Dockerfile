FROM node:18-alpine AS node
EXPOSE 80

WORKDIR /app
COPY . .
RUN npm install
RUN npm run build --prod

FROM nginx:alpine
COPY --from=node /app/default.conf /etc/nginx/conf.d/default.conf
COPY --from=node /app/dist/client /usr/share/nginx/html
CMD ["nginx", "-g", "daemon off;"]