﻿using CleanArc.Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace CleanArc.Domain.Entities.User;

public class UserToken:IdentityUserToken<int>,IEntity
{
    public UserToken()
    {
        GeneratedTime=DateTime.UtcNow;
    }

    public User User { get; set; }
    public DateTime GeneratedTime { get; set; }

}