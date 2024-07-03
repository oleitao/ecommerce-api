using System.Net.Mail;

namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record EmailDto(Guid Id,string Tag,string Body,/*List<Attachment>? attachments,*/bool IsBodyHtml,MailPriority Priority,string Message,string Subject);
}
