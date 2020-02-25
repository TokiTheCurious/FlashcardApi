using Microsoft.AspNetCore.Mvc;
using Service.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashcardApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        IUserService service;
        public UserController(IUserService _service)
        {
            service = _service;
        }


    }
}
