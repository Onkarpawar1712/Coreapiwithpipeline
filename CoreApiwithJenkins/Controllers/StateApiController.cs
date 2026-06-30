using CoreApiwithJenkins.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApiwithJenkins.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class StateApiController : ControllerBase
    {
        [HttpGet]
        [Route("api/state")]

        public List<State> GetState()

        {
            List<State> lst = new List<State>();
            lst.Add(new State() {StateId = 101, Statename="Maharashtra"});
            lst.Add(new State() { StateId = 102, Statename = "Gujarat" });
            lst.Add(new State() { StateId = 103, Statename = "Uttar Pradesh" });
            lst.Add(new State() { StateId = 104, Statename = "Odisa" });
            lst.Add(new State() { StateId = 105, Statename = "Karnataka" });
            lst.Add(new State() { StateId = 106, Statename = "Uttarpradesh" });
            lst.Add(new State() { StateId = 107, Statename = "Nepal" });
            lst.Add(new State() { StateId = 108, Statename = "Andhrapradesh" });

            return lst;
        }

    }
}
