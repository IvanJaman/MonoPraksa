interface IItem
{
    public string Title { get; set; }
    public string Id { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public bool IsBorrowed { get; set; }
    public string GetInfo();
}

