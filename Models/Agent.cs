using AgentManagementMVC.Enums;
using System.ComponentModel.DataAnnotations;


namespace AgentManagementMVC.Models
{
    public class Agent : BaseModel
    {
        public string nickname { get; set; }

        public AgentStatus AgentStatus { get; set; }



    }
}
