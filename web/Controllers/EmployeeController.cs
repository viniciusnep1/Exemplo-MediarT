using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using services.services.employee.commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {

        private readonly IMediator mediator;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger, IMediator mediator)
        {
            _logger = logger;
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] ReadEmployeeCommand command)
        {
            if (command == null) 
                return await Task.FromResult(BadRequest("Command id null"));

            var response = await mediator.Send(command);
            return await Task.FromResult(Ok(response));
        }
    }
}
