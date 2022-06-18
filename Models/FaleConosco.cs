using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Studioarianearaujo_ATV5.Models
{
    public class FaleConosco
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public string Elogios {get;set;}
        public string Sugestoes {get;set;}
    }
}