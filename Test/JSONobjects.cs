using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONparse
{
    public class Rootobject
    {
        public int Code { get; set; }
        public string Status { get; set; }
        public object Message { get; set; }
        public Messages Messages { get; set; }
        public Data Data { get; set; }
        public string Timestamp { get; set; }
        public string IPAddress { get; set; }
    }

    public class Messages
    {
    }

    public class Data
    {
        public Titlerow[] TitleRows { get; set; }
    }

    public class Titlerow
    {
        public string Name { get; set; }
        public Title[] Titles { get; set; }
    }

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
        public Continuewatching ContinueWatching { get; set; }
        public object[] Episodes { get; set; }
        public int LoadTime { get; set; }
    }

    public class Continuewatching
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

