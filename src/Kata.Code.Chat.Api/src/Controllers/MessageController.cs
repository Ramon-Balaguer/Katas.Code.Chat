using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kata.Code.Chat.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kata.Code.Chat.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private IChatRoom chatRoom;

        public MessageController(IChatRoom chatRoom)
        {
            this.chatRoom = chatRoom;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<V1.ChatMessage>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(chatRoom.ShowMessages().Select(message => message.ToDto()).ToList());
        }
    }
}