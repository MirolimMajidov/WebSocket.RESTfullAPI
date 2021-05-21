﻿using System;
using System.Collections.Generic;

namespace AspNetCore.WebSocket.RESTfullAPI
{
    public class WSController
    {
        public string Name { get; set; }

        public Type Controller { get; set; }

        public List<WSMethod> Methods { get; set; } = new List<WSMethod>();
    }
}
