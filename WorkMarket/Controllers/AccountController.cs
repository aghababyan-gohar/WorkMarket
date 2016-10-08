using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WorkMarket.BL.DTOs.Auth;
using WorkMarket.BL.Services.Auth;
using WorkMarket.ViewModels;

namespace WorkMarket.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : BaseController
    {
        //TODO: Add dependency injection here
        private AuthService _service;

        public AccountController()
        {
            _service = new AuthService();
        }


        [AllowAnonymous]
        [Route("Register")]
        public async Task<IHttpActionResult> Register(UserViewModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //TODO: add automapper mapping here
            var user = new UserDTO
            {
                UserName = userModel.UserName,
                Password = userModel.Password
            };
            IdentityResult result = await _service.RegisterUser(user);

            IHttpActionResult errorResult = GetErrorResult(result);

            if (errorResult != null)
            {
                return errorResult;
            }

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _service.Dispose();
            }

            base.Dispose(disposing);
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }
    }
}