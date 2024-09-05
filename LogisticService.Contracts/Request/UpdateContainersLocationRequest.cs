using LogisticService.Contracts.OtherModels;

namespace LogisticService.Contracts.Request;

public class UpdateContainersLocationRequest
{
    public List<UpdateLocationApiModel> ContainersList { get; set; }
}