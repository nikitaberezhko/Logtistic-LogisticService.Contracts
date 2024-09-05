namespace LogisticService.Contracts.Request;

public class GetContainersLocationByOrderIdRequest
{
    public Guid OrderId { get; set; }
}