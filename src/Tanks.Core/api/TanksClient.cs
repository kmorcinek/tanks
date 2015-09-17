using System;
using System.Net;
using Newtonsoft.Json;
using RestSharp;

namespace Tanks.Core.api
{


    //using ClientProperties = org.glassfish.jersey.client.ClientProperties;
    //using GZipEncoder = org.glassfish.jersey.message.GZipEncoder;
    //using Logger = org.slf4j.Logger;
    //using LoggerFactory = org.slf4j.LoggerFactory;

    ////using JsonProcessingException = com.fasterxml.jackson.core.JsonProcessingException;
    ////using DeserializationFeature = com.fasterxml.jackson.databind.DeserializationFeature;
    ////using ObjectMapper = com.fasterxml.jackson.databind.ObjectMapper;

    //using Throwables = jersey.repackaged.com.google.common.@base.Throwables;

    public class TanksClient
    {
        //private static readonly Logger log = LoggerFactory.getLogger(typeof(TanksClient));
        private string url;
        private string tournamentId;
        private string accessToken;
        private WebClient client;

        public TanksClient(string url, string tournamentId, string accessToken)
        {
            this.url = url;
            this.tournamentId = tournamentId;
            this.accessToken = accessToken;
            this.client = new WebClient();
            //client.property(ClientProperties.CONNECT_TIMEOUT, 300000);
            //client.property(ClientProperties.READ_TIMEOUT, 300000);
            //client.register(typeof(GZipEncoder));
            //this.mapper = (new ObjectMapper()).configure(DeserializationFeature.FAIL_ON_UNKNOWN_PROPERTIES, false);
        }

        public virtual TurnResult submitMove(Command move)
        {
            //log.info("Sending {}", move);
            return request<TurnResult>("moves", move, Method.POST);
        }

        public virtual GameSetup MyGameSetup
        {
            get { return request<GameSetup>("http://10.12.202.141:9999/tournaments/master/games/my/setup", null, Method.GET); }
        }

        private RESULT request<RESULT>(string path, Command command, RestSharp.Method method)
        {
            var restClient = new RestClient(path);
            restClient.AddDefaultHeader("Authorization", accessToken);
            restClient.AddDefaultHeader("Accept-Encoding", "gzip");

            var request = new RestRequest(method);

            request.RequestFormat = DataFormat.Json;

            IRestResponse response = restClient.Execute(request);

            return readResponse<RESULT>(response);
        }

        private RESULT readResponse<RESULT>(IRestResponse response)
        {
            //log.info(responseText);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception();
            }
            return JsonConvert.DeserializeObject<RESULT>(response.Content);
        }
    }
}