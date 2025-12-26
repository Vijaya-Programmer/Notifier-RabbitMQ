# Notifier-RabbitMQ
Demonstration of Messaging using RabbitMQ - with .Net and Angular

Lets create a Backend with .Net 8.0 and use Nuget package for Rabbit MQ. 
Lets also try some of its exchanges - fanout , topic. 

We have a Angular Admin portal and Angular clients. 

Angular Admin sends the message via backend API and Messgaes will be received by RabbitMQ in it and based on exchanges it sends to the clients. 

Stage 1: Added folders 
    1. Backend : using .Net API 
    2. Docs : to give a brief  on the projects
    3. Frontend : Angular clients , angular admin 
    4. RabbitMQ Broker: Using .Net for integrating MessageMQ as a worker service 


