
using System;
using System.Linq;
using System.Text.Json;
using System.Xml;
using DotNet.Responses;

namespace DotNet
{
    public static class Program
    {
        private const string ApiKey = "";  // TODO: Enter your API key
        // The different map names can be found on considition.com/rules
        private const string Map = "training1";     // TODO: Enter your desired map
        private const int bag_type = 1 // TODO: Enter your desired bag type

        private static readonly GameLayer GameLayer = new(ApiKey);
        
        public static void Main(string[] args)
        {
            var gameInformation = GameLayer.MapInfo(Map);
            Solver solver = new Solver();
            var solution = solver.Solve(gameInformation.population, gameInformation.companyBudget, gameInformation.behavior);
            var submitSolution = GameLayer.Submit(JsonSerializer.Serialize(solution), Map);
           
            Console.WriteLine("Your GameId is: " + submitSolution.GameId);
            Console.WriteLine("Your score is: " + submitSolution.Score);
            Console.WriteLine("Your weekly results is: " + submitSolution.Weeks);
            Console.WriteLine("Your amount of produced bags is: " + submitSolution.ProducedBags);
            Console.WriteLine("Your amount of destroyed bags is: " + submitSolution.DestroyedBags);
            Console.WriteLine("Link to visualisation" + submitSolution.Link);
    
        }
    }
}
