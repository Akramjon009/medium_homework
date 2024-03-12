﻿using MediatR;

namespace Medium.Application.UseCases.MediumUser.Commands
{
    public class CreateUserCommand : IRequest
    {
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Bio { get; set; }
        public string? PhotoPath { get; set; }
        public int FollowersCount { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }




    }
}
