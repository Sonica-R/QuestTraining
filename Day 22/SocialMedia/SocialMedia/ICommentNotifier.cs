using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    public interface ICommentNotifier
    {
         void Notify(string UserId, string CommentedUserId,  string Comment);
    }
}
