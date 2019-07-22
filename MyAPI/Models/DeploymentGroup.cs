using System.Collections.Generic;

namespace MyAPI.Models
{
    /// <summary>
    /// Describes the deployment options for an entire fullstack development team.
    /// Holds all team member information and possible deployment targets
    /// </summary>
    public class DeploymentGroup
    {
        public long Id {get;set;}
        public string Name {get;set;}

        public List<DeploymentTarget> targets {get;set;}
        public List<TeamMember> team {get;set;} 

    }
}