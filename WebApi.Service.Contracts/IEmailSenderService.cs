﻿using Model;
using System.Net.Mail;

namespace WebApi.Service.Contracts
{
    public interface IEmailSenderService
    {
        public Task<Email> GetContent(Guid accountValidation, User user, string arguments, bool trackChanges);
        public Task SendEmailAsync(string email, string subject, string message, List<Attachment> attachments);
        public Task SendEmailAsync(string email, string subject, string message);
        public Task SendEmailAsync(string email, Email content);
        public Task<User?> GetUserAsync(Guid id, bool trackChanges);
    }
}
