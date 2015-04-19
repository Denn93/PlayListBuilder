using System.Collections.Generic;

namespace Dennis.Development.PlaylistBuilder.Console.Entities
{
    internal class Show
    {
        public int ShowId { get; set; }

        public string Name { get; set; }

        public List<Episode> Episodes { get; set; }
    }
}