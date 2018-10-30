using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonModels
{
    public class Title
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortSynopsis { get; set; }
        public string MediumSynopsis { get; set; }
        public string LongSynopsis { get; set; }
        public string KeyArtUrl { get; set; }
        public string MasterArtUrl { get; set; }
        public string Rating { get; set; }
        public float OverallRating { get; set; }
        public int UserRating { get; set; }
        public int? RunTime { get; set; }
        public string ShowInfoTitle { get; set; }
        public DateTime FirstPremiereDate { get; set; }
        public int EpisodeCount { get; set; }
        public string SeasonName { get; set; }
        public string RokuHDArtUrl { get; set; }
        public string RokuSDArtUrl { get; set; }
        public bool IsRateable { get; set; }
        public bool InQueue { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsContinueWatching { get; set; }
        public ContinueWatching ContinueWatching { get; set; }
        public object[] Episodes { get; set; }
        public int LoadTime { get; set; }
    }

}
