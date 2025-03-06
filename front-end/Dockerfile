FROM node:18-alpine

LABEL authors="Sangwoo Ha"

RUN apk add --no-cache git bash

WORKDIR /ayu-front-end

RUN git clone https://github.com/AYU-CSE/Frontend.git . 
RUN npm install

EXPOSE 5173

CMD ["npm", "run", "dev", "--", "--host"]