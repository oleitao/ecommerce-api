namespace WebApi.Services
{
    public class EmailSettings
    {
        public string FromName { get; set; } = null!;
        public string FromAddress { get; set; } = null!;
        public string ToEmail { get; set; } = null!;
        public string CcEmail { get; set; } = null!;
        public string BccEmail { get; set; } = null!;
        public string ServerAddress { get; set; } = null!;
        public int ServerPort { get; set; } = 0!;
        public bool ServerUseSsl { get; set; } = false!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
