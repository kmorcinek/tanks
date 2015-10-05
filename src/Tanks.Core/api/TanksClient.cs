using System;
using System.Net;
using Newtonsoft.Json;
using RestSharp;

namespace Tanks.Core.api
{
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

        public virtual TurnResult SubmitMove(Command move)
        {
            //log.info("Sending {}", move);
            return Request<TurnResult>("/moves", move, Method.POST);
        }

        public GameSetup MyGameSetup()
        {
            return Request<GameSetup>("/games/my/setup", null, Method.GET);
        }

        private TResult Request<TResult>(string path, Command command, RestSharp.Method method)
        {
            var restClient = new RestClient(this.url + this.tournamentId + path);
            restClient.AddDefaultHeader("Authorization", accessToken);
            restClient.AddDefaultHeader("Accept-Encoding", "gzip");

            var request = new RestRequest(method);
            //request.AddHeader("Content-Type", "application/json");

            if (method == Method.POST)
            {
                var serialize = request.JsonSerializer.Serialize(command);
                request.AddParameter("application/json", serialize, ParameterType.RequestBody);
                //request.AddBody(serialize);
            }
            request.RequestFormat = DataFormat.Json;

            IRestResponse response = restClient.Execute(request);

            return ReadResponse<TResult>(response);
        }

        private static TResult ReadResponse<TResult>(IRestResponse response)
        {
            //log.info(responseText);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Console.WriteLine(response.StatusCode + " status to byl");
                throw new Exception();
            }
            return JsonConvert.DeserializeObject<TResult>(response.Content);
        }
    }
}