namespace PortailService.Mail
{
    public class MailSetting
    {
        public string Mail { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }

        public MailSetting() { }

        public MailSetting(string mail, string displayName, string password, string host, int port)
        {
            Mail = mail;
            DisplayName = displayName;
            Password = password;
            Host = host;
            Port = port;
        }
    }

    
}
