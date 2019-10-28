using System;
using Microsoft.AspNetCore.Mvc;
using FluentAssertions;
using Kata.Code.Chat.Api.Controllers;
using NSubstitute;
using Xunit;

namespace Kata.Code.Chat.Api.UnitTests
{
    public class MessageControllerShould
    {
        [Fact]
        public void SendMessages()
        {
            var chatRoom = Substitute.For<IChatRoom>();


            var messageController = new MessageController(chatRoom);

            var result = messageController.Get();
                
            result.Should().BeOfType<OkResult>();

        }
    }
}
