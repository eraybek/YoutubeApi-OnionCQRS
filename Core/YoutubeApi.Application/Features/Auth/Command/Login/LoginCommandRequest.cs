using MediatR;
using System.ComponentModel;

namespace YoutubeApi.Application.Features.Auth.Command.Login
{
    public class LoginCommandRequest : IRequest<LoginCommandResponse>
    {
        [DefaultValue("aybek17@itu.edu.tr")]
        public string Email { get; set; }

        [DefaultValue("123456")]
        public string Password { get; set; }
    }
}
