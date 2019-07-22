using System.ComponentModel.DataAnnotations;

namespace MyAPI.Models
{
    /// <summary>
    /// Represents a single person on a development team.
    /// Contains identifying information and their credentials.
    /// </summary>
    public class TeamMember
    {
        public RollType roll;

        [Key]
        public string email {get;set;}
        public string name {get;set;}
        Credentials credentials;
    }
    public enum RollType { Dev, QA, BA }
}