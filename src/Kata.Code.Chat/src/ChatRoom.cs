using System;
using System.Collections.Generic;

namespace Kata.Code.Chat
{
    public class ChatRoom
    {
        private List<ChatMessage> messages;

        public ChatRoom()
        {
            messages = new List<ChatMessage>()
            {
                new ChatMessage("Welcome to chat!", "system", new DateTime(1900, 1, 1))
            };
        }

        public List<ChatMessage> ShowMessages()
        {
            return messages;
        }
    }
}