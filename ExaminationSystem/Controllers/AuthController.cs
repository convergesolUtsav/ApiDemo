using ES.Domain.Identity;
using ES.Repository.IRespository;
using ExaminationSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace ExaminationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IJWTManagerRepository _jWTManagerRepository;

        public AuthController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, SignInManager<ApplicationUser> signInManager, IJWTManagerRepository jWTManagerRepository)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _jWTManagerRepository = jWTManagerRepository;
        }
        [HttpPost("Register")]
        public async Task<ActionResult> Register(RegiserVM registerVM, string roleName = "User")
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            ApplicationUser user = new ApplicationUser()
            {
                UserName = registerVM.UserName,
                Email = registerVM.Email,
                PhoneNumber = registerVM.PhoneNumber,
            };
            IdentityResult result = await _userManager.CreateAsync(user, registerVM.Password);

            if(!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("Register", error.Description);

                }
                return BadRequest(result.Errors);
            }
            ApplicationRole applicationRole = await _roleManager.FindByNameAsync(roleName);
            if(applicationRole == null)
            {
                applicationRole = new ApplicationRole() { Name = roleName };
                await _roleManager.CreateAsync(applicationRole);
            }
            await _userManager.AddToRoleAsync(user, applicationRole.Name);

            return Ok(user);
        }
        [HttpPost("SignIn")]
        public async Task<ActionResult> SignIn(SigninVM signinVM)
        {
            var user = await GetUserByEmailOrUserName(signinVM.EmailOrUserName);
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid creadentials");
                return BadRequest("Please Enter Valid data");
            }
            await _signInManager.PasswordSignInAsync(user, signinVM.Password, signinVM.RememberMe, lockoutOnFailure: false);
        if(await _userManager.IsInRoleAsync(user, "Admin"))
            {
                return RedirectToAction("Index", "Admin");
            }
            var token = _jWTManagerRepository.Authenticate(user.UserName, user.PasswordHash);
            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(token);
        }

        private async Task<ApplicationUser> GetUserByEmailOrUserName(string emailOrUserName)
        {
            return emailOrUserName.Contains("@")
                ? await _userManager.FindByEmailAsync(emailOrUserName)
                : await _userManager.FindByNameAsync(emailOrUserName);
        }
        [HttpGet("Signout")]
        public async Task<ActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return Ok("Success");
        }


    }
}
