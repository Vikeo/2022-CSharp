using DotNet.models;

namespace DotNet
{
    public class SubmitResponse
    {
        public int Score;
        public string GameId;
        public bool valid;
        public System.Collections.Generic.List<WeekModel> Weeks;
        public int ProducedBags;
        public int DestroyedBags;
        public string Link;
    }
}