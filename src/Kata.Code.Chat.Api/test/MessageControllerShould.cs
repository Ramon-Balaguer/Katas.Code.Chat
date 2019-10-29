using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FluentAssertions;
using Kata.Code.Chat.Api.Controllers;
using Kata.Code.Chat.Api.Models;
using Microsoft.CodeAnalysis;
using NSubstitute;
using Xunit;

namespace Kata.Code.Chat.Api.UnitTests
{
    public class MessageControllerShould
    {
        [Fact]
        public void SendWelcomeMessage()
        {
            var welcomeMessage = new ChatMessage("Welcome to chat!", "system", new DateTime(1900, 1, 1));

            var chatRoom = Substitute.For<IChatRoom>();
            chatRoom.ShowMessages().Returns(new List<ChatMessage> {welcomeMessage});

            var messageController = new MessageController(chatRoom);

            var result = messageController.Get();
                
            result.Should().BeOfType<OkObjectResult>();
            result.As<OkObjectResult>().Value.Should().BeOfType<List<V1.ChatMessage>>();
            result.As<OkObjectResult>().Value.As<List<V1.ChatMessage>>().Should()
                .ContainSingle(message => message == welcomeMessage.ToDto());
        }
    }
}
