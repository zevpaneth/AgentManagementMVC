using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgentManagementMVC.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Missions : ControllerBase
    {
        private readonly HttpClient _httpClient = new HttpClient();

        // GET: api/<Missions>
        [HttpGet]
        public async Task<string> GetAsync()
        {
            JsonResult result = (JsonResult)await _httpClient.GetFromJsonAsync<object>("https://localhost:7160/missions");
            string value = JsonSerializer.Serialize(result);
            return new string(value);
            
        }

        // GET api/<Missions>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Missions>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Missions>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Missions>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
