using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.App.Commands.Request;
using Hukuk.Takip.Sistemi.App.Commands.Response;
using Hukuk.Takip.Sistemi.App.Queries.Request;
using Hukuk.Takip.Sistemi.App.Queries.Response;
using Hukuk.Takip.Sistemi.Entities.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hukuk.Takip.Sistemi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusterilerController : ControllerBase
    {
        IMediator _mediator;

        public MusterilerController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost("CreateMusteri")]
        public async Task<IActionResult> CreateMusteri([FromBody] CreateMusteriRequest requestModel)
        {

            CreateMusteriResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpPut("UpdateMusteri")]
        public async Task<IActionResult> UpdateMusteri([FromBody] UpdateMusteriRequest requestModel)
        {

            UpdateMusteriResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }


        [HttpGet("GetAll")]

        public async Task<IActionResult> GetAll([FromQuery] GetAllMusteriRequest requestModel)

        {

            List<GetAllMusteriResponse> response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("GetById")]

        public async Task<IActionResult> GetById([FromQuery] GetByIdMusteriRequest requestModel)
        {

            GetByIdMusteriResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

       


        [HttpGet("GetMusteriNo")]
        public async Task<IActionResult> GetMusteriNo([FromQuery] GetMusteriNoRequest requestModel)
        {

            GetMusteriNoResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}