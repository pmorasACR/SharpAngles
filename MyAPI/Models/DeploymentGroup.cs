using System.Collections.Generic;

namespace MyAPI.Models
{
    /// <summary>
    /// Describes the deployment options for an entire fullstack development team.
    /// Holds all team member information and possible deployment targets
    /// </summary>
    public class DeploymentGroup
    {
        DeploymentTarget production;
        DeploymentTarget development;
        DeploymentTarget testing;
        List<TeamMember> team; 

    }
}