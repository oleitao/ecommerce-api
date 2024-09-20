using AutoMapper;
using Microsoft.Extensions.Options;
using Model;
using System.Net;
using System.Net.Mail;
using WebApi.Contracts;
using WebApi.Entities.Exceptions;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        private readonly IDataShaper<CategoryDto> _dataShaper;

        const string TagContent = "[CONTENT]";
        const string TagSubject = "[TITLE]";

        public EmailSettings _emailSettings { get; }

        public EmailSenderService(IRepositoryManager repository, AutoMapper.IMapper mapper, IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;

            _repository = repository;
            _mapper = mapper;
        }

        public Task SendEmailWithAttachmentsAsync(string email, string subject, string message, List<Attachment> attachments)
        {
            Execute(email, subject, message, attachments).Wait();

            return Task.FromResult(0);
        }

        public async Task Execute(string email, string subject, string message, List<Attachment> attachments)
        {
            try
            {
                var toEmail = string.IsNullOrEmpty(email) ? _emailSettings.ToEmail : email;

                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress(_emailSettings.FromAddress, _emailSettings.FromName)
                };

                mail.To.Add(new MailAddress(toEmail));

                if (!string.IsNullOrEmpty(_emailSettings.CcEmail))
                    mail.CC.Add(new MailAddress(_emailSettings.CcEmail));

                if (!string.IsNullOrEmpty(_emailSettings.BccEmail))
                    mail.Bcc.Add(new MailAddress(_emailSettings.BccEmail));

                if (attachments != null)
                {
                    foreach (var item in attachments)
                    {
                        mail.Attachments.Add(item);
                    }
                }

                mail.Subject = subject;
                mail.Body = message;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.Normal;

                using (SmtpClient smtp = new SmtpClient(_emailSettings.ServerAddress, _emailSettings.ServerPort))
                {
                    smtp.Credentials = new NetworkCredential(_emailSettings.Username, _emailSettings.Password);
                    smtp.EnableSsl = _emailSettings.ServerUseSsl;

                    await smtp.SendMailAsync(mail);
                }
            }
            catch
            {
                throw new Exception();
            }
        }

        public async Task SendEmailAsync(string email, string subject, string message, List<Attachment> attachments)
        {
            try
            {
                var toEmail = string.IsNullOrEmpty(email) ? _emailSettings.ToEmail : email;

                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress(_emailSettings.FromAddress, _emailSettings.FromName)
                };

                mail.To.Add(new MailAddress(toEmail));

                if (!string.IsNullOrEmpty(_emailSettings.CcEmail))
                    mail.CC.Add(new MailAddress(_emailSettings.CcEmail));

                if (!string.IsNullOrEmpty(_emailSettings.BccEmail))
                    mail.Bcc.Add(new MailAddress(_emailSettings.BccEmail));

                if (attachments != null)
                {
                    foreach (var item in attachments)
                    {
                        mail.Attachments.Add(item);
                    }
                }

                mail.Subject = subject;
                mail.Body = message;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.Normal;

                using (SmtpClient smtp = new SmtpClient(_emailSettings.ServerAddress, _emailSettings.ServerPort))
                {
                    smtp.Credentials = new NetworkCredential(_emailSettings.Username, _emailSettings.Password);
                    smtp.EnableSsl = _emailSettings.ServerUseSsl;

                    await smtp.SendMailAsync(mail);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            try
            {
                var toEmail = string.IsNullOrEmpty(email) ? _emailSettings.ToEmail : email;

                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress(_emailSettings.FromAddress, _emailSettings.FromName)
                };

                mail.To.Add(new MailAddress(toEmail));

                if (!string.IsNullOrEmpty(_emailSettings.CcEmail))
                    mail.CC.Add(new MailAddress(_emailSettings.CcEmail));

                if (!string.IsNullOrEmpty(_emailSettings.BccEmail))
                    mail.Bcc.Add(new MailAddress(_emailSettings.BccEmail));

                mail.Subject = subject;
                mail.Body = message;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.Normal;
                
                using (SmtpClient smtp = new SmtpClient(_emailSettings.ServerAddress, _emailSettings.ServerPort))
                {
                    smtp.Timeout = 30000;
                    smtp.Credentials = new NetworkCredential(_emailSettings.FromAddress, _emailSettings.Password);
                    smtp.EnableSsl = _emailSettings.ServerUseSsl;
                    smtp.UseDefaultCredentials = false;

                    await smtp.SendMailAsync(mail);
                }
            }
            catch
            {
                throw new Exception();
            }
        }

        public async Task<Email> GetContent(Guid accountValidation, User user, string arguments, bool trackChanges)
        {
            try
            {
                var content = await _repository.Email.GetEmailContent(accountValidation, trackChanges);
                if (content == null)
                    throw new EmailContentNotFound(accountValidation);

                if(string.IsNullOrEmpty(arguments))
                    content.Body = content.Body.Replace(TagSubject, content.Subject);
                else
                    content.Body = content.Body.Replace(TagContent, content.Content + arguments);

                return content;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetContent)} : {ex}");
            }
        }

        public async Task<User?> GetUserAsync(Guid id, bool trackChanges)
        {
            var user = await _repository.User.GetUserAsync(id, trackChanges);
            if (user is null)
                throw new UserNotFoundException();

            return user;
        }

        public async Task SendEmailAsync(string email, Email content)
        {
            try
            {
                var toEmail = string.IsNullOrEmpty(email) ? _emailSettings.ToEmail : email;

                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress(_emailSettings.FromAddress, _emailSettings.FromName)
                };

                mail.To.Add(new MailAddress(toEmail));

                if (!string.IsNullOrEmpty(_emailSettings.CcEmail))
                    mail.CC.Add(new MailAddress(_emailSettings.CcEmail));

                if (!string.IsNullOrEmpty(_emailSettings.BccEmail))
                    mail.Bcc.Add(new MailAddress(_emailSettings.BccEmail));

                mail.Subject = content.Subject;
                mail.Body = content.Body;
                mail.IsBodyHtml = content.IsBodyHtml;
                mail.Priority = content.Priority;

                using (SmtpClient smtp = new SmtpClient(_emailSettings.ServerAddress, _emailSettings.ServerPort))
                {
                    smtp.Timeout = 30000;
                    smtp.Credentials = new NetworkCredential(_emailSettings.FromAddress, _emailSettings.Password);
                    smtp.EnableSsl = _emailSettings.ServerUseSsl;
                    smtp.UseDefaultCredentials = false;

                    await smtp.SendMailAsync(mail);
                }
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
