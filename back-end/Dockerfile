# FROM docker:latest

# LABEL authors="Sangwoo Ha"

# RUN apk add --no-cache git

# WORKDIR /ayu-back-end

# RUN git clone https://github.com/AYU-CSE/Backend.git .

# WORKDIR ./

# EXPOSE 3000

# COPY . .


# Docker 환경이 필요한 컨테이너 이미지 사용
FROM docker:latest

# 필수 도구 설치
RUN apk add --no-cache git

# 작업 디렉토리 설정
WORKDIR /app

# GitHub 리포지토리 클론
RUN git clone https://github.com/AYU-CSE/Backend.git project

# 프로젝트 내부로 이동
WORKDIR /app/project/

EXPOSE 8000
# CMD에서 Docker 빌드 실행
CMD ["sh", "-c", "if [ -f Dockerfile ]; then docker build -t inner-container . && docker run --rm inner-container; else echo 'No Dockerfile found, skipping build.'; fi"]
