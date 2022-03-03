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
    public class MusteriAdreslerController : ControllerBase
    {
        IMediator _mediator;

        public MusteriAdreslerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreateMusteriAdres")]
        public async Task<IActionResult> CreateMusteriAdres([FromBody] CreateMusteriAdresRequest requestModel)
        {

            CreateMusteriAdresResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllMusteriAdresRequest requestModel)
        {

            List<GetAllMusteriAdresResponse> response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById([FromQuery] GetByIdMusteriAdresRequest requestModel)
        {

           GetByIdMusteriAdresResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpPut("UpdateMusteriAdres")]
        public async Task<IActionResult> UpdateMusteri([FromBody] UpdateMusteriAdresRequest requestModel)
        {

            UpdateMusteriAdresResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("GetMusteriAdresler")]

        public async Task<IActionResult> GetMusteriAdresler([FromQuery] GetMusteriAdreslerRequest requestModel)
        {

            List<GetMusteriAdreslerResponse> response = await _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}