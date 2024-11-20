using CodenamesServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodenamesServer.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private static List<AnonymousUser> _userRepository { get; set; } = new();

        [HttpPost("initialize")]
        public async Task<IActionResult> InitializeUser([FromBody] UserInitializationRequest request)
        {
            var existingUser = _userRepository.Where(x => x.Fingerprint.Equals(request.fingerprint)).FirstOrDefault();

            if (existingUser != null)
            {
                return Ok(new { anonymousId = existingUser.Id });
            }

            var newUser = new AnonymousUser
            {
                Id = Guid.NewGuid().ToString(),
                Fingerprint = request.fingerprint,
                CreatedAt = DateTime.UtcNow
            };

            _userRepository.Add(newUser);

            return Ok(new { anonymousId = newUser.Id });
        }
    }

    public record UserInitializationRequest(string fingerprint);
}
