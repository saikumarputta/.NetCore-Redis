# .NetCore-Redis
asp.net core using redis to store keyvalue pairs in memory database(cache/ram)

#Redis
Redis is In-Memory datastructure or used to store keys value pair in the database or InMemory(cache).

#Running Redis in your local
docker pull redis
docker run --name local-redis -p 6379:6379 -d redis:latest
docker ps
docker exec -it local-redis  /bin/bash
redis-cli
ping
set key value
get key

important urls:
https://localhost:44395/api/redis?key=k1     //for get request
https://localhost:44395/api/redis?key=k2&value=ram        //for post request
