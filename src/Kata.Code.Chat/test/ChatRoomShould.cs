using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Xunit;

namespace Kata.Code.Chat.UnitTests
{
    public class ChatRoomShould
    {
        [Fact]
        public void ShowWelcomeMessageWhenChatIsInitialized()
        {
            var welcomeMessage = new ChatMessage("Welcome to chat!", "system", new DateTime(1900, 1,1));
            var chatRoom = new ChatRoom(); 
            
            chatRoom.ShowMessages().Should().ContainSingle(m => m == welcomeMessage);
        }
    }
}
