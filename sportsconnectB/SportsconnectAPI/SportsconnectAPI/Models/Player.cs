using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsconnectAPI.Models
{
    [PrimaryKey(nameof(Id))]
    public class Player
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string sport { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public DateTime lastActive { get; set; }
        public string attending { get; set; }
        public int pCode { get; set; }
    }
}
