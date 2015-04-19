using System.IO;

namespace Dennis.Development.PlaylistBuilder.Console.Entities
{
    internal class Episode : IShowable
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }
    }
}