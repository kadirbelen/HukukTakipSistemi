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
    public class AvukatAtananUrunController : ControllerBase
    {
        IMediator _mediator;

        public AvukatAtananUrunController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreateAvukatAtananUrun")]
        public async Task<IActionResult> CreateMusteri([FromBody] CreateAvukatAtananUrunRequest requestModel)
        {

            CreateAvukatAtananUrunResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllAvukatAtananUrunRequest requestModel)
        {

            List<GetAllAvukatAtananUrunResponse> response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("GetAvukatAtananUrunler")]

        public async Task<IActionResult> GetAvukatAtananUrunler([FromQuery] GetAvukatAtananUrunlerRequest requestModel)
        {

            List<GetAvukatAtananUrunlerResponse> response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpPut("UpdateAvukatAtananUrun")]
        public async Task<IActionResult> UpdateAvukatAtananUrun([FromBody] UpdateAvukatAtananUrunRequest requestModel)
        {

            UpdateAvukatAtananUrunResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }


        [HttpGet("GetById")]
        public async Task<IActionResult> GetById([FromQuery] GetByIdAvukatAtananUrunRequest requestModel)
        {

            GetByIdAvukatAtananUrunResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}