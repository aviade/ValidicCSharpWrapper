﻿namespace ValidicCSharp.Model
{
    using System.Net;

    public class BaseResponse
    {
        public HttpStatusCode code { get; set; }
        public string message { get; set; }
    }
}
