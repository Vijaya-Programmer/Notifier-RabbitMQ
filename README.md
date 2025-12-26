# Notifier-RabbitMQ
Demonstration of Messaging using RabbitMQ - with .Net and Angular

Lets create a Backend with .Net 8.0 and use Nuget package for Rabbit MQ. 
Lets also try some of its exchanges - fanout , topic. 

We have a Angular Admin portal and Angular clients. 

Angular Admin sends the message via backend API and Messgaes will be received by RabbitMQ in it and based on exchanges it sends to the clients. 

# git in action: 
1. initialize git : git init
2. add git repo : git remote add origin https://github.com/USERNAME/REPO.git
       git remote -v 
3. to Stage the changes : git add . 
                          git commit -m "comments"
4. push to repo : git push -u origin main 
                  git push 
5. to pull : git pull origin main


# Stage 1: Added folders 
    1. Backend : using .Net API 
    2. Docs : to give a brief  on the projects
    3. Frontend : Angular clients , angular admin 
    4. RabbitMQ Broker: Using .Net for integrating MessageMQ as a worker service 

# Stage 2: add gitignore 
    1. dotnet new gitignore and append for angular :

    # Angular : node_modules/ dist/ .angular/


# Stage 3: Backend API Creation

1. dotnet new webapi -n RabbitMQ.Publisher.Api
2. cd RabbitMQ.Publisher.Api
3. add RabbitMQ package : dotnet add package RabbitMQ.Client
4. add folders Controllers, models, services,congifuration

# Stage 4: RabbitMQBroker.Consumer.worker 

1. dotnet new worker -n  RabbitMQBroker.Consumer.worker
2. cd RabbitMQBroker.Consumer.worker
3. dotnet add package RabbitMQ.Client
4. mkdir consumers Configurations 

# Stage 5: front end ( 2 projects )

1. ng new rabbitmq-admin-ui --routing --style=css
2. ng new rabbitmq-client-ui --routing --style=css

# RabbitMQ Messaging Demo (.NET 8 + Angular)

This repository demonstrates asynchronous messaging using RabbitMQ with:
- .NET 8 Web API (Publisher)
- .NET 8 Worker Service (Consumer)
- Angular Admin UI
- Angular Client UI

## Repository Structure
- backend/  → Message publisher API
- worker/   → Message consumer
- frontend/ → Angular applications
- docs/     → Architecture & setup docs

## Messaging Patterns
- Fanout Exchange
- Topic Exchange

## Prerequisites
- .NET 8 SDK
- Node.js 18+
- RabbitMQ running locally

## How to Run (No Docker)
1. Start RabbitMQ
2. Run `RabbitMQ.Publisher.Api`
3. Run `RabbitMQ.Consumer.Worker`
4. Run Angular Admin UI
5. Run Angular Client UI





