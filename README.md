# AspnetMicroservices
AspnetMicroservices

**Run** 

docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d

Exposed Endpoints 
http://localhost:8001/swagger/index.html - catalog.api
http://localhost:8002/swagger/index.html - basket.api
http://localhost:8004/swagger/index.html - ordering.api
http://localhost:8005/swagger/index.html - shopping aggregator
http://localhost:8006 - aspnetFrontEnd

Implemeneted - Rabbit MQ, Mongo DB, Redis, PostgresSQL, SQL Server, Catalog.API, Basket.API,Discount.Grpc, ordering-api, rabbit mq and mass transit between basket.api and ordering.api, API Gateway, Client Aps


In-progress - 
On the horizon
WebStatus Healthchecks 

Final Goal 
![110304529-c5b70180-800c-11eb-832b-a2751b5bda76](https://user-images.githubusercontent.com/1406029/122149229-5cbc0280-ce21-11eb-81d5-22f050bc534d.png)
