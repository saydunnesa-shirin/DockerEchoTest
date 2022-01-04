@echo off

docker-compose -f .\docker-compose.yml up --build --detach
echo "Local environment has started for server and client"
start cmd /k docker exec -i -t echoserver bash
start cmd /k docker logs --follow echoclient
pause
docker-compose -f .\docker-compose.yml down