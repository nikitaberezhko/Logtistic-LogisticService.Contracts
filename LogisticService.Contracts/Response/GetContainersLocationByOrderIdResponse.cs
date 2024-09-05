using LogisticService.Contracts.OtherModels;

namespace LogisticService.Contracts.Response;

public class GetContainersLocationByOrderIdResponse
{
    public List<ContainerApiModel> Containers { get; set; }
}