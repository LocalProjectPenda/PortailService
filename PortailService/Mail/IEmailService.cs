
using System.Threading.Tasks;

namespace PortailService.Mail
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailData mailData);
    }
}
