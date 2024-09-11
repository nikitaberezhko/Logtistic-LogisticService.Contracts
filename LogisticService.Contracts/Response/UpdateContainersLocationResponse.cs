using LogisticService.Contracts.OtherModels;

namespace LogisticService.Contracts.Response;

public class UpdateContainersLocationResponse
{
    public List<LogisticContainerApiModel> Containers { get; set; }
}