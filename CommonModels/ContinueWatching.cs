using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonModels
{
    public class ContinueWatching
    {
        public string Id { get; set; }
        public int ProfileId { get; set; }
        public int EpisodeId { get; set; }
        public string Status { get; set; }
        public int CurrentTime { get; set; }
        public int UserId { get; set; }
        public int TitleId { get; set; }
        public int SeasonId { get; set; }
        public int VideoId { get; set; }
        public int TotalSeconds { get; set; }
        public DateTime CreatedDT { get; set; }
        public DateTime? ModifiedDT { get; set; }
    }
}
