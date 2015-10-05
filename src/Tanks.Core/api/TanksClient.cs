using System;
using RestSharp;

namespace Tanks.Core.api
{
    public class TanksClient
    {
        //private static readonly Logger log = LoggerFactory.getLogger(typeof(TanksClient));
        private readonly string _url;
        private readonly string _tournamentId;
        private readonly string _accessToken;

        public TanksClient(string url, string tournamentId, string accessToken)
        {
            _url = url;
            _tournamentId = tournamentId;
            _accessToken = accessToken;
        }

        public virtual TurnResult SubmitMove(Command command)
        {
            //log.info("Sending {}", move);
            var request = new RestRequest(Method.POST);
            var serialize = request.JsonSerializer.Serialize(command);
            request.AddParameter("application/json", serialize, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            return Request<TurnResult>("/moves", request);
        }

        public GameSetup GetMyGameSetup()
        {
            var request = new RestRequest(Method.GET)
            {
                RequestFormat = DataFormat.Json
            };

            return Request<GameSetup>("/games/my/setup", request);
        }

        private TResult Request<TResult>(string path, IRestRequest request) where TResult : new()
        {
            var restClient = new RestClient(this._url + this._tournamentId + path);
            restClient.Timeout = TimeSpan.FromSeconds(30).Milliseconds;

            restClient.AddDefaultHeader("Authorization", _accessToken);
            restClient.AddDefaultHeader("Accept-Encoding", "gzip");

            var restResponse = restClient.Execute<TResult>(request);

            return restResponse.Data;
        }
    }
}