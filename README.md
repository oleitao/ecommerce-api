# ecommerce-api

This project is based on a [multi vendor e-commerce  website](https://github.com/Asfak00/multi-vendor-ecommerce) to load data through a WebApi .NET Core API 7.

## How to run e-commerce website

![alt text](https://github.com/oleitao/ecommerce-api/blob/main/images/website.jpg?raw=true)

1. Go to `WebSite` folder
2. Install project dependencies with command `npm i`
3. Run `npm run dev`


## How to run docker compose

![alt text](https://github.com/oleitao/ecommerce-api/blob/main/images/docker.jpg?raw=true)

1. Go to `WebApi` folder
2. Run 
```console
docker-compose -f docker-compose.yml up
```
3. Check if all services are running without erros on local docker

## How to create migrations

1. Go to `WebSite` folder
2. Run 
```console
dotnet ef migrations add InitialMigration
dotnet ef database update
```
3. Check if after migration your database use the same schema as on the follow model image
![alt text](https://github.com/oleitao/ecommerce-api/blob/main/images/model.jpg?raw=true)

## How to check Redis cache memory
install on your local machine `redis-cli` to connect to you Redis host server using the follow command in your command line:
```console
redis-cli -h 127.0.0.1 -p 6379
```

![alt text](https://github.com/oleitao/ecommerce-api/blob/main/images/redis.jpg?raw=true)

## How to run test BDD (Behavior Driven Development)

![alt text](https://github.com/oleitao/ecommerce-api/blob/main/images/BDD.jpg?raw=true)

1. Go to `WebApi.Tests` folder
2. Verify if you've [SpecFlow](https://specflow.org/) dependence installed
3. Run 
```console
dotnet test WebApi.Tests\WebApi.Tests.csproj
```


## How to run WebApi

![alt text](https://github.com/oleitao/ecommerce-api/blob/main/images/swagger.jpg?raw=true)

### Set Environment Keys

While we develop our application, we use the “development” environment. But as soon as we publish our application, it goes to the “production” environment. Development and production environments should have different URLs, ports, connection strings, passwords, and other sensitive information.
Therefore, we need to have a separate configuration for each environment and that’s easy to accomplish by using .NET Core-provided mechanisms.

To set which environment our application runs on, we need to set up the `ASPNETCORE_ENVIRONMENT` environment variable. For example, to run the application in production, we need to set it to the Production value on the machine we do the deployment to.
We can set the variable through the command prompt by typing `set ASPNETCORE_ENVIRONMENT=Production` in Windows or `export ASPNET_CORE_ENVIRONMENT=Production` in Linux.


```console
setx SECRET "43443FDFDF34DF34343fdf344SDFSDFSDFSDFSDF4545354345SDFGDFGDFGDFGdffgfdGDFGDGR%" /M
```


1. Go to `WebApi` folder
2. Run
```console
dotnet build
dotnet run WebApi\WebApi.csproj
```
3. Using Postman try to retrive data from https://localhost:8080/api/v1.1/v1/categories




## How to Monitorize WebApi Performance

Check if you Prometheus and Grafana host containers are running.

* Prometheus
    * Prometheus can collect and store metrics as time-series data, recording information with a timestamp.

http://localhost:9090/metrics

* Grafana
    * Grafana provides you an visualization web application analytics and interactive. It can produce charts, graphs, and alerts for the web when connected to supported data sources.

http://localhost:3000/dashboards


![alt text](https://github.com/oleitao/ecommerce-api/blob/main/images/grafana-1.jpg?raw=true)

`http://localhost:3000/d/64nrElFmk/docker-prometheus-monitoring?orgId=1&refresh=10s&__feature.autoMigrateOldPanels=true`

![alt text](https://github.com/oleitao/ecommerce-api/blob/main/images/grafana-2.jpg?raw=true)

`http://localhost:3000/d/7LdPlUZnz/my-web-api-dashboard?orgId=1&refresh=5s`

![alt text](https://github.com/oleitao/ecommerce-api/blob/main/images/grafana-3.jpg?raw=true)

`http://localhost:3000/d/lmTFsljGk/node-exporter-full-with-node-name?orgId=1`

![alt text](https://github.com/oleitao/ecommerce-api/blob/main/images/grafana-4.jpg?raw=true)

`http://localhost:3000/d/xfpJB9FGz/server-status-dashboard?orgId=1`


## How to Log WebApi

Check if you ElasticSearch and Kibana host containers are running.

* Kibana
    * Is a data visualization and exploration tool used for log and time-series analytics, application monitoring, and operational intelligence use cases. It offers powerful and easy-to-use features such as histograms, line graphs, pie charts, heat maps, and built-in geospatial support.

* ElasticSearch
    * Elasticsearch is a distributed search and analytics engine and is commonly used for log analytics, full-text search, security intelligence, business analytics, and operational intelligence use cases.

![alt text](https://github.com/oleitao/ecommerce-api/blob/main/images/elasticsearch_kibana.jpg?raw=true)

`http://localhost:5601/`
