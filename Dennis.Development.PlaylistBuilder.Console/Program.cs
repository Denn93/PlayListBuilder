using Dennis.Development.PlaylistBuilder.Console.Entities;

namespace Dennis.Development.PlaylistBuilder.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Start playlistbuilder");

            PlayList playList = PlayListBuilder.Create();

            System.Console.WriteLine("End playlistbuilder");
        }
    }
}