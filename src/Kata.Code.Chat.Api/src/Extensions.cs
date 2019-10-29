using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kata.Code.Chat.Api.Models;

namespace Kata.Code.Chat.Api
{
    public static class Extensions
    {
        public static V1.ChatMessage ToDto(this ChatMessage chatMessage)
        {
            return new V1.ChatMessage(chatMessage.Text, chatMessage.User, chatMessage.CreationTime);
        }
    }
}
