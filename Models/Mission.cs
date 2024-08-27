using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using AgentManagementMVC.Enums;

namespace AgentManagementMVC.Models
{
    public class Mission
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Agent"), TypeConverter("int")]
        public int AgentId { get; set; }

        [ForeignKey("Target"), TypeConverter("int")]
        public int TargetId { get; set; }

        public double? Timer { get; set; }

        public double? ExecutionTime { get; set; }

        public MissionStatus MissionStatus { get; set; }
    }
}
