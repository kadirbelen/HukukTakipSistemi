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
    public class MusteriUrunlerController : ControllerBase
    {
        IMediator _mediator;

        public MusteriUrunlerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreateMusteriUrun")]
        public async Task<IActionResult> CreateMusteri([FromBody] CreateMusteriUrunRequest requestModel)
        {

            CreateMusteriUrunResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllMusteriUrunRequest requestModel)
        {

            List<GetAllMusteriUrunResponse> response = await _mediator.Send(requestModel);
            return Ok(response);
        }



        [HttpGet("GetById")]
        public async Task<IActionResult> GetById([FromQuery] GetByIdMusteriUrunRequest requestModel)
        {

            GetByIdMusteriUrunResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpPut("UpdateMusteriUrun")]
        public async Task<IActionResult> UpdateMusteri([FromBody] UpdateMusteriUrunRequest requestModel)
        {

            UpdateMusteriUrunResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("GetMusteriUrunler")]

        public async Task<IActionResult> GetMusteriUrunler([FromQuery] GetMusteriUrunlerRequest requestModel)
        {

            List<GetMusteriUrunlerResponse> response = await _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}