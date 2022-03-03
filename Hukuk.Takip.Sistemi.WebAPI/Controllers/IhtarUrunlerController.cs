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
    public class IhtarUrunlerController : ControllerBase
    {
        IMediator _mediator;

        public IhtarUrunlerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreateIhtarUrun")]
        public async Task<IActionResult> CreateMusteri([FromBody] CreateIhtarUrunRequest requestModel)
        {

            CreateIhtarUrunResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllIhtarUrunRequest requestModel)
        {

            List<GetAllIhtarUrunResponse> response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("GetIhtarUrunler")]

        public async Task<IActionResult> GetIhtarUrunler([FromQuery] GetIhtarUrunlerRequest requestModel)
        {

            List<GetIhtarUrunlerResponse> response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpPut("UpdateIhtarUrun")]
        public async Task<IActionResult> UpdateIhtarUrun([FromBody] UpdateIhtarUrunRequest requestModel)
        {

            UpdateIhtarUrunResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById([FromQuery] GetByIdIhtarUrunRequest requestModel)
        {

            GetByIdIhtarUrunResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}