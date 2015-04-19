using Dennis.Development.PlaylistBuilder.Console.Entities;
using System.Collections.Generic;

namespace Dennis.Development.PlaylistBuilder.Console
{
    internal class PlayListBuilder
    {
        public PlayListBuilder(List<Show> shows, List<Commercial> commercials)
        {
            Shows = shows;
            Commercials = commercials;
        }

        public PlayList Create()
        {
            PlayList result = new PlayList { Content = new List<IShowable>() };

            foreach (Show show in Shows)
            {
                foreach (Episode episode in show.Episodes)
                {
                    result.Content.Add(episode);
                }
            }

            return result;
        }

        public List<Show> Shows { get; private set; }

        public List<Commercial> Commercials { get; private set; }
    }
}