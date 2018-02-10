using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiltersSample.Filters;

namespace FiltersSample.Helper
{
    [AddHeader("Author", "Steve Smith @xxxjjjjjjxxardalis")]
    public class BaseController : Controller
    {

    }
}
