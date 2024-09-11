using LogisticService.Contracts.OtherModels;

namespace LogisticService.Contracts.Response;

public class GetContainersLocationResponse
{
    public List<LogisticContainerApiModel> Containers { get; set; }
}