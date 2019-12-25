using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class Room
    {
        public string Title { get; set; }
        public string Descript { get; set; }
        public string Time { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int MinYears { get; set; }
        public string Address { get; set; }
        public string Phones { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public double Rate { get; set; }
        public int Fear { get; set; }
        public int Сomplexity { get; set; }
        public string Logo { get; set; }
    }
}