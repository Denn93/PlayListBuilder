namespace Dennis.Development.PlaylistBuilder.Console.Entities
{
    internal interface IShowable
    {
        int Id { get; set; }

        string Title { get; set; }

        string Location { get; set; }
    }
}