namespace RabbitMQ.publisher.Api.Models
{
  public class PublishMessageRequest
  {
    public string Message { get; set; } = string.Empty;
    public string? RoutingKey { get; set; }
  }
}