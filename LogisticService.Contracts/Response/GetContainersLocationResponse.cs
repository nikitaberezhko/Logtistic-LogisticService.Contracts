using LogisticService.Contracts.OtherModels;

namespace LogisticService.Contracts.Response;

public class GetContainersLocationResponse
{
    public List<ContainerApiModel> Containers { get; set; }
}