﻿using System.ComponentModel.DataAnnotations;

namespace Medium.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public string? UserName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        public string? Bio { get; set; }
        public string? PhotoPath { get; set; }
        public int FollowersCount { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }

        public DateTimeOffset JoinDate { get; set; } = DateTimeOffset.UtcNow;
        public DateTime ModifiedDate { get; set; }
        public DateTime DeletedDaate { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
