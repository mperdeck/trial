using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebNonCore1.Models
{
    public class JsonResultMessage : JsonResult
    {
        public JsonResultMessage(bool result) : base() //################### JsonResult now must have object. status code is no longer in the result
        {
            Result = result;
            HttpStatusCode = HttpStatusCode.OK;
        }

        public JsonResultMessage(HttpStatusCode httpStatusCode) : base() //###################
        {
            Result = false;
            HttpStatusCode = httpStatusCode;
        }

        public JsonResultMessage(HttpStatusCode httpStatusCode, ModelStateDictionary modelState) : base() //###################
        {
            Result = false;
            HttpStatusCode = httpStatusCode;
            ModelState = modelState;
        }

        public bool Result { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
        public ModelStateDictionary ModelState { get; set; }
    }
}