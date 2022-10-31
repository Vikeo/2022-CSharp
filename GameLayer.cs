using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DotNet.Responses;
using Newtonsoft.Json;

namespace DotNet
{
    public class GameLayer
    {
        private readonly Api _api;

        public GameLayer(string apiKey)
        {
            _api = new Api(apiKey);
        }

        ///  <summary> Creates a new game.</summary>
        ///  <param name="mapName">map choice </param>
        public GameResponse MapInfo(string mapName)
        {
            var state = _api.MapInfo(mapName).Result;
            return state;
        }

        ///  <summary> Submits your solution for validation and scoring.</summary>
        /// <param name="solution"> Your solution</param>
        ///  <param name="mapName">map choice </param>
        public SubmitResponse Submit(string solution, string mapName)
        {
            var state = _api.SubmitGame(solution, mapName).Result;
            return state;
        }
    }
}
