﻿namespace itlapr.Web.Models.Response
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public dynamic Data { get; set; }
    }
}
