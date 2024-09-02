
    class Book : IItem
    {
        public string Title { get; set; }
        public string Id { get; set; }
        public string Author { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public bool IsBorrowed { get; set; }

        public string GetInfo()
        {
            return $"Title: {Title}, id: {Id}, author: {Author}, release date: {ReleaseDate}";
        }
    }
