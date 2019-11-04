using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kata.Code.Chat.Api.Models
{
    public static partial class V1
    {
        public class ChatMessage
        {
            protected bool Equals(ChatMessage other)
            {
                return string.Equals(Text, other.Text) && string.Equals(User, other.User) &&
                       CreationTime.Equals(other.CreationTime);
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != this.GetType()) return false;
                return Equals((ChatMessage) obj);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    var hashCode = (Text != null ? Text.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (User != null ? User.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ CreationTime.GetHashCode();
                    return hashCode;
                }
            }

            public static bool operator ==(ChatMessage left, ChatMessage right)
            {
                return Equals(left, right);
            }

            public static bool operator !=(ChatMessage left, ChatMessage right)
            {
                return !Equals(left, right);
            }

            public string Text { get; }
            public string User { get; }
            public DateTime CreationTime { get; }

            public ChatMessage(string text, string user, DateTime creationTime)
            {
                this.Text = text;
                this.User = user;
                this.CreationTime = creationTime;
            }
        }
    }
}
