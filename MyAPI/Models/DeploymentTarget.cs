using System.Collections.Generic;
using System;
namespace MyAPI.Models
{
    /// <summary>
    /// Specifies a deployment instance (usually production, test, or development) and all the servers related to that instance
    /// </summary>
    internal class DeploymentTarget
    {

        List<DeploymentServer> databases;
        List<DeploymentServer> webservers;


        public bool requiredCredentials(Credentials creds){
            //TODO write method
            throw new NotImplementedException();
        }
    }
}