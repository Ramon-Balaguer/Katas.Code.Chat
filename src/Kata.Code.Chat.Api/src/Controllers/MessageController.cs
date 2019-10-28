using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult Get()
        {
            return Ok();
        }
    }
}