using Microsoft.Azure.Cosmos;
using System;

namespace NoSqlApp.Utils
{
    public static class Shared
    {
        private static string EndpointUrl => Environment.GetEnvironmentVariable("CosmosEndpoint");
        private static string AuthorizationKey => Environment.GetEnvironmentVariable("CosmosMasterKey");

        public static CosmosClient Client { get; private set; }

        static Shared()
        {
            Client = new CosmosClient(EndpointUrl, AuthorizationKey);
        }
    }
}
