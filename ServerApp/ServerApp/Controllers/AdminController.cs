using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using ServerApp.Model;
using ServerApp.Repository;

namespace ServerApp.Controllers
{
    public class AdminController:Controller
    {
        private readonly AdminInfoRepository _adminInfoRepository = new AdminInfoRepository();

        [HttpPost ("api/admin/SignUp")]
        public IActionResult Add([FromBody] AdminInfo admin) {
            var adminInfo = _adminInfoRepository.getByUsername(admin.Username);
            if (adminInfo== null)
            {
                var a = _adminInfoRepository.Add(admin); 
                return Ok(true);
            }
            else {
                return Ok("Already Exist");
            }
        }

        [HttpPost("api/admin/SignIn")]
        public IActionResult SignIn([FromBody] AdminInfo admin) {
            if (admin.Username!=null) {
                var admin1 =_adminInfoRepository.getByPassword(admin.password);
                if (admin1 != null)
                {
                    if (admin.Username == admin1.Username)
                    {
                        if (admin.password == admin1.password)
                        {
                            return Ok(true);
                        }
                        else
                        {
                            return Ok("Incorrect Password");
                        }
                    }
                    else {
                        return Ok(false);
                    }
                }
                else {
                    return Ok("Invalid username.SignUp");
                }
            }
            else{
                return Ok(false);
            }
        }

    }
}
