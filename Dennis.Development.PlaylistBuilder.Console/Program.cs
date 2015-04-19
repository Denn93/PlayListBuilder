using Dennis.Development.PlaylistBuilder.Console.Entities;
using System.Collections.Generic;

namespace Dennis.Development.PlaylistBuilder.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Start playlistbuilder");

            PlayList playList = new PlayListBuilder(LoadData(), GetCommercials()).Create();

            foreach (IShowable showable in playList.Content)
                System.Console.WriteLine(showable.Title);

            System.Console.WriteLine("End playlistbuilder");
            System.Console.ReadLine();
        }

        private static List<Show> LoadData()
        {
            List<Show> result = new List<Show>
            {
                new Show
                {
                    Name = "Yu gi oh",
                    Episodes = new List<Episode>
                    {
                        new Episode {Id = 1, Title = "1 - Yu gi oh Pilot", Location = "C:/Somewhere"},
                        new Episode {Id = 2, Title = "2 - Yu gi oh - Ep 2", Location = "C:/Somewhere"},
                        new Episode {Id = 3, Title = "3 - Yu gi oh - Ep 3", Location = "C:/Somewhere"},
                        new Episode {Id = 4, Title = "4 - Yu gi oh - Ep 4", Location = "C:/Somewhere"},
                        new Episode {Id = 5, Title = "5 - Yu gi oh - Ep 5", Location = "C:/Somewhere"},
                        new Episode {Id = 6, Title = "6 - Yu gi oh - Ep 6", Location = "C:/Somewhere"},
                        new Episode {Id = 7, Title = "7 - Yu gi oh - Ep 7", Location = "C:/Somewhere"},
                    }
                },
                new Show
                {
                    Name = "BeyBlade",
                    Episodes = new List<Episode>
                    {
                        new Episode {Id = 1, Title = "1 - BeyBlade - Pilot", Location = "C:/Somewhere"},
                        new Episode {Id = 2, Title = "2 - BeyBlade - Ep 2", Location = "C:/Somewhere"},
                        new Episode {Id = 3, Title = "3 - BeyBlade - Ep 3", Location = "C:/Somewhere"},
                        new Episode {Id = 4, Title = "4 - BeyBlade - Ep 4", Location = "C:/Somewhere"},
                        new Episode {Id = 5, Title = "5 - BeyBlade - Ep 5", Location = "C:/Somewhere"},
                        new Episode {Id = 6, Title = "6 - BeyBlade - Ep 6", Location = "C:/Somewhere"},
                        new Episode {Id = 7, Title = "7 - BeyBlade - Ep 7", Location = "C:/Somewhere"},
                    }
                }
            };

            return result;
        }

        private static List<Commercial> GetCommercials()
        {
            List<Commercial> result = new List<Commercial>
            {
                new Commercial{Id = 1, Title = "1 - Commercial Break"},
                new Commercial{Id = 2, Title = "2 - Commercial Castel Break"},
                new Commercial{Id = 3, Title = "3 - Commercial Desert Break"},
                new Commercial{Id = 4, Title = "4 - Commercial Jungle Break"},
                new Commercial{Id = 5, Title = "5 - Commercial Space Break"}
            };

            return result;
        }
    }
}