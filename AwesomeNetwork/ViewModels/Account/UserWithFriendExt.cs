﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbContext.Models.Users;

namespace AwesomeNetwork.ViewModels.Account
{
    public class UserWithFriendExt: User
    {
        public bool IsFriendWithCurrent { get; set; }
    }
}
