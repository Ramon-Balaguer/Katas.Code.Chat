using System.Collections.Generic;

namespace Kata.Code.Chat
{
    public interface IChatRoom
    {
        List<ChatMessage> ShowMessages();
    }
}