class DVD : IItem
{
    public string Title { get; set; }
    public string Id { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public string Duration { get; set; }
    public bool IsBorrowed { get; set; }

    public string GetInfo()
    {
        return $"Title: {Title}, id: {Id}, release date: {ReleaseDate}, duration: {Duration}";
    }
}