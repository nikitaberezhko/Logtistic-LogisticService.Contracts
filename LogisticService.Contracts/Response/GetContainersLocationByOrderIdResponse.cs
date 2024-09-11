using LogisticService.Contracts.OtherModels;

namespace LogisticService.Contracts.Response;

public class GetContainersLocationByOrderIdResponse
{
    public List<LogisticContainerApiModel> Containers { get; set; }
}