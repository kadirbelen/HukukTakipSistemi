﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Commands.Response
{
    public class CreateIhtarUrunResponse:IRequest<CreateIhtarResponse>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

    }
}
