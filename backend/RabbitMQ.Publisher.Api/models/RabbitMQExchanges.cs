using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace RabbitMQ.Publisher.Api.Models
{
  public class RabbitMQExchanges
  {
    public const string fanout = "demo.fanout";
    public const string topic ="demo.topic";
    
  }
}