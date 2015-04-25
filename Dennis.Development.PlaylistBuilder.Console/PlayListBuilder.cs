using Dennis.Development.PlaylistBuilder.Console.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dennis.Development.PlaylistBuilder.Console
{
    internal class PlayListBuilder
    {
        private readonly int _totalEpisodeCount;

        public PlayListBuilder(List<Show> shows, List<Commercial> commercials)
        {
            Shows = shows;
            Commercials = commercials;
            _totalEpisodeCount = (shows != null) ? shows.Where(m => m.Episodes != null).Sum(m => m.Episodes.Count) : 0;
        }

        public PlayList Create()
        {
            PlayList result = new PlayList { Content = new List<List<IShowable>>() };

            int insertCount = 0;
            int commercialCount = 0;
            int day = -1;
            Random random = new Random();

            while (insertCount < _totalEpisodeCount)
            {
                Show show = Shows[random.Next(0, Shows.Count)];

                if (show.Episodes.Count == 0)
                    continue;

                if (insertCount % 25 == 0)
                {
                    day++;
                    result.Content.Add(new List<IShowable>());
                }

                if (commercialCount > random.Next(1, 3))
                {
                    result.Content[day].Add(Commercials[random.Next(0, Commercials.Count)]);
                    commercialCount = 0;
                }
                else
                    commercialCount++;

                result.Content[day].Add(show.Episodes.Dequeue());
                insertCount++;
            }

            return result;
        }

        public List<Show> Shows { get; private set; }

        public List<Commercial> Commercials { get; private set; }
    }
}