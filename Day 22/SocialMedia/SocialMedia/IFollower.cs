﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    public interface IFollower
    {
        void Notify(string UserId, string FollowerId);
    }
}
