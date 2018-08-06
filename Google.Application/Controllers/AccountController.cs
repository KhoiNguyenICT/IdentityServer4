using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Google.Application.Controllers
{
    public class AccountController: GoogleController
    {
        public readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            this._accountService = accountService;
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> Get()
        {
            var result = await _accountService.GetAllAsync();
            return Ok(result);
        }
    }
}
