using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace MyAPI.Models
{
    /// <summary>
    /// Specifies a deployment instance (usually production, test, or development) and all the servers related to that instance
    /// </summary>
    public class DeploymentTarget
    {
        public long Id {get;set;} //every model class requires an Id key. ([key] annotation can be used instead)

        EnvironmentType environment;
        public string Name {get;set;}
        public string OS {get;set;}
        public IPAddress Address {get;set;}
        public string Hostname {get;set;}
        List<DeploymentServer> databases;
        List<DeploymentServer> webservers;


        public bool requiredCredentials(Credentials creds){
            //TODO write method
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// Describes what type of development environment a deployment target is
    /// </summary>
    public enum EnvironmentType { Development, Testing, Production, Staging, Integration }
}