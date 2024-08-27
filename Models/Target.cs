using AgentManagementAPI.Classes;
using AgentManagementMVC.Enums;
using System.ComponentModel.DataAnnotations;

namespace AgentManagementMVC.Models
{
    public class Target : BaseModel
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public TargetStatus TargetStatus { get; set; }
    }


}