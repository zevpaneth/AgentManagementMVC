﻿using AgentManagementAPI.Classes;
using System.ComponentModel.DataAnnotations;

namespace AgentManagementMVC.Models
{
    public class BaseModel
    {

        [Key]
        public int Id { get; set; }

        public string photoUrl { get; set; } // => Link to the picture

        public Location? Location { get; set; }


    }
}
