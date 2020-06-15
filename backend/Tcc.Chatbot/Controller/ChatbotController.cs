using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Tcc.Chatbot.Service;

namespace Tcc.Chatbot.Controller
{
    [Route("api/chatbot")]
    [ApiController]
    public class ChatbotController : ControllerBase
    {
        private readonly AlunoService _alunoService;

        public ChatbotController(AlunoService alunoService) =>
            (_alunoService) = (alunoService);

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] WebhookRequest webhookRequest)
        {
            // Console.WriteLine(JsonConvert.SerializeObject(await _alunoService.GetAsync(1)));
            return Ok(await _alunoService.GetAsync(1));
        }
    }
}