in TERMINAL.<br>
Make sure your terminal path is in `~Docker\front-end`

### 1. build dockerfile
Usage : front-end /origin/develop branch . 
```
docker build -t ayu-cse-frontend .
```
`>> You only need to run this command once.`

### 2. run docker image
```
docker run -p 5173:5173 --name front-cse ayu-cse-frontend
```
### 3. connect
Connect via localhost port 5173<br>
[http://localhost:5173](http://localhost:5173)

### 4. shutdown
If you can still control the terminal, stop it with `Ctrl+C`.<br>
Otherwise follows the command `docker stop front-cse`

### 5. delete docker container
```
docker rm front-cse
```
### 6. delete docker image
```
docker rmi ayu-cse-frontend
```
This dockerfile purposed on just preview frontend.
To connect to the AYU backend, follow this [link]().
