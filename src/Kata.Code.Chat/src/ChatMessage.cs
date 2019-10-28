using System;

namespace Kata.Code.Chat
{
    public class ChatMessage  
    {
        protected bool Equals(ChatMessage other)
        {
            return string.Equals(text, other.text) && string.Equals(user, other.user) && creationTime.Equals(other.creationTime);
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
                var hashCode = (text != null ? text.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (user != null ? user.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ creationTime.GetHashCode();
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

        private readonly string text;
        private readonly string user;
        private readonly DateTime creationTime;

        public ChatMessage(string text, string user, DateTime creationTime)
        {
            this.text = text;
            this.user = user;
            this.creationTime = creationTime;
        }
    }
}