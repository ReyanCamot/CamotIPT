using System;

namespace IPT102CamotDomain.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int? ReleaseYear { get; set; }
        public int? RuntimeMinutes { get; set; }
        public decimal? Rating { get; set; }
    }
}
