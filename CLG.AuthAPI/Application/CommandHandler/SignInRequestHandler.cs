using AutoMapper;
using CLG.AuthAPI.Application.Command.Request;
using CLG.AuthAPI.Application.Command.Response;
using CLG.AuthAPI.Application.Models;
using CLG.AuthAPI.Application.Notifications;
using CLG.AuthAPI.Application.Repositories;
using CLG.AuthAPI.Application.Services;
using MediatR;

namespace CLG.AuthAPI.Application.CommandHandler
{
    public class SignInRequestHandler : IRequestHandler<SignInRequest, SignInResponse>
    {
        private readonly IMediator _mediator;
        private readonly IRepository<User> _repository;
        private readonly IMapper _mapper;
        public SignInRequestHandler(IMediator mediator, IRepository<User> repository, IMapper mapper)
        {
            this._mediator = mediator;
            this._repository = repository;
            this._mapper = mapper;
        }
        public async Task<SignInResponse> Handle(SignInRequest request, CancellationToken cancellationToken)
        {
            var response = _mapper.Map<SignInResponse>(_repository.Get(request.Username, request.Password));
            if (response is null)
                await _mediator.Publish(new SignInNotification { Username = request.Username, Message = "Username or Password is incorrect!" });
            else
            {
                await _mediator.Publish(new SignInNotification { Username = response.Username, Message = "Signin Success" });
                response.Token = TokenService.Generate(response.Username);
            }

            return await Task.FromResult(response);
        }
    }
}
