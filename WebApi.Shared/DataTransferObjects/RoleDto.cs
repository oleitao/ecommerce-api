using System.ComponentModel.DataAnnotations;

namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record RoleDto
    {
        [Required(ErrorMessage = "Id is required")] public Guid? Id { get; init; }
        [Required(ErrorMessage = "Tag is required")] public string? Tag { get; init; }
    }
}
