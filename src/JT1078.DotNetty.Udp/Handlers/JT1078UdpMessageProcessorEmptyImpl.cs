﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JT1078.DotNetty.Core.Interfaces;
using JT1078.DotNetty.Core.Metadata;
using JT1078.Protocol;

namespace JT1078.DotNetty.Udp.Handlers
{
    class JT1078UdpMessageProcessorEmptyImpl : IJT1078UdpMessageHandlers
    {
        public Task<JT1078Response> Processor(JT1078Request request)
        {
            return Task.FromResult<JT1078Response>(default);
        }
    }
}
