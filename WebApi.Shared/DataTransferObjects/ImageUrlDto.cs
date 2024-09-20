using Model;

namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record ImageUrlDto(
        Guid Id,
        string Public_id,
        string Url,
        Guid ProductId
    );

    public record ImageUrlForCreationDto(string Public_id, string Url, Guid ProductId);

    public record ImageUrlForUpdateDto(string Public_id, string Url, Guid ProductId);
}
