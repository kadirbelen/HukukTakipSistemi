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
    public class MusteriTelefonlarController : ControllerBase
    {
        IMediator _mediator;

        public MusteriTelefonlarController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreateMusteriTelefon")]
        public async Task<IActionResult> CreateMusteri([FromBody] CreateMusteriTelefonRequest requestModel)
        {

            CreateMusteriTelefonResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("GetAll")]

        public async Task<IActionResult> GetAll([FromQuery] GetAllMusteriTelefonRequest requestModel)
        {

            List<GetAllMusteriTelefonResponse> response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById([FromQuery] GetByIdMusteriTelefonRequest requestModel)
        {

            GetByIdMusteriTelefonResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpPut("UpdateMusteriTelefon")]
        public async Task<IActionResult> UpdateMusteri([FromBody] UpdateMusteriTelefonRequest requestModel)
        {

            UpdateMusteriTelefonResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }



        [HttpGet("GetMusteriTelefonlar")]

        public async Task<IActionResult> GetMusteriTelefonlar([FromQuery] GetMusteriTelefonlarRequest requestModel)
        {

            List<GetMusteriTelefonlarResponse> response = await _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}