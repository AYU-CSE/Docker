# PLEASE CHECKING YOUR WORKING PATH !!
`WIN/MAC PATH : ~\AYU-CSE`

# docker build
```
docker build -f Docker\front-end\real-time\Dockerfile -t ayu-real-time Frontend
```

# docker run
```
docker run -it -d --name ayu-real-time-container -v "${PWD}\Frontend:/WORKDIR" -p 5173:5173 ayu-real-time
```