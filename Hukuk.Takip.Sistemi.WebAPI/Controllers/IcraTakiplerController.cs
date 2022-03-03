using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.App.Commands.Request;
using Hukuk.Takip.Sistemi.App.Commands.Response;
using Hukuk.Takip.Sistemi.App.Queries.Request;
using Hukuk.Takip.Sistemi.App.Queries.Response;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hukuk.Takip.Sistemi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IcraTakiplerController : ControllerBase
    {
        IMediator _mediator;

        public IcraTakiplerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreateIcraTakip")]
        public async Task<IActionResult> CreateIcraTakip([FromBody] CreateIcraTakipRequest requestModel)
        {

            CreateIcraTakipResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("GetIcraTakipler")]

        public async Task<IActionResult> GetMusteriTelefonlar([FromQuery] GetIcraTakiplerRequest requestModel)
        {

            List<GetIcraTakiplerResponse> response = await _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}