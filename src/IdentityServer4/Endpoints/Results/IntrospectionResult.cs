﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityServer4.Hosting;
using Microsoft.AspNetCore.Http;

namespace IdentityServer4.Endpoints.Results
{
    public class IntrospectionResult : IEndpointResult
    {
        public Dictionary<string, object> Result { get; private set; }

        public IntrospectionResult(Dictionary<string, object> result)
        {
            Result = result;
        }
        
        public Task ExecuteAsync(HttpContext context)
        {
            context.Response.SetNoCache();
            return context.Response.WriteJsonAsync(Result);
        }
    }
}