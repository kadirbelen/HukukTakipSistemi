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
    public class IhtarlarController : ControllerBase
    {
        IMediator _mediator;

        public IhtarlarController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreateIhtar")]
        public async Task<IActionResult> CreateIhtarlar([FromBody] CreateIhtarRequest requestModel)
        {

            CreateIhtarResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllIhtarRequest requestModel)
        {

            List<GetAllIhtarResponse> response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("GetIhtarlar")]

        public async Task<IActionResult> GetMusteriIhtarlar([FromQuery] GetIhtarlarRequest requestModel)
        {

            List<GetIhtarlarResponse> response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpPut("UpdateIhtar")]
        public async Task<IActionResult> UpdateIhtar([FromBody] UpdateIhtarRequest requestModel)
        {

            UpdateIhtarResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById([FromQuery] GetByIdIhtarRequest requestModel)
        {

            GetByIdIhtarResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}