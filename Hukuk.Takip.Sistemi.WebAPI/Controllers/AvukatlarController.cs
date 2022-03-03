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
    public class AvukatlarController : ControllerBase
    {
        IMediator _mediator;

        public AvukatlarController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreateAvukat")]
        public async Task<IActionResult> CreateMusteri([FromBody] CreateAvukatRequest requestModel)
        {

            CreateAvukatResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllAvukatRequest requestModel)
        {

            List<GetAllAvukatResponse> response = await _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}