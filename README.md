# Notifier-RabbitMQ
Demonstration of Messaging using RabbitMQ - with .Net and Angular

Lets create a Backend with .Net 8.0 and use Nuget package for Rabbit MQ. 
Lets also try some of its exchanges - fanout , topic. 

We have a Angular Admin portal and Angular clients. 

Angular Admin sends the message via backend API and Messgaes will be received by RabbitMQ in it and based on exchanges it sends to the clients. 

git in action: 
1. initialize git : git init
2. add git repo : git remote add origin https://github.com/USERNAME/REPO.git
       git remote -v 
3. to Stage the changes : git add . 
                          git commit -m "comments"
4. push to repo : git push -u origin main 
                  git push 
5. to pull : git pull origin main



Stage 1: Added folders 
    1. Backend : using .Net API 
    2. Docs : to give a brief  on the projects
    3. Frontend : Angular clients , angular admin 
    4. RabbitMQ Broker: Using .Net for integrating MessageMQ as a worker service 

Stage 2: add gitignore 
    1. dotnet new gitignore and append for angular :

    # Angular : node_modules/ dist/ .angular/


Stage 2: Backend API Creation

1. dotnet new webapi -n RabbitMQ.Publisher.Api
2. cd RabbitMQ.Publisher.Api
3. add RabbitMQ package : dotnet add package RabbitMQ.Client
4. add folders Controllers, models, services,congifuration

Stage 3: RabbitMQBroker.Consumer.worker 

1. dotnet new worker -n  RabbitMQBroker.Consumer.worker
2. cd RabbitMQBroker.Consumer.worker
3. dotnet add package RabbitMQ.Client







