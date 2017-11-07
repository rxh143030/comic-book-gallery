using System;

// Containers attributes and behaviors

namespace ComicBookGal.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public Boolean Favorite { get; set; }

        public string DisplayText
        {
            get{
                return SeriesTitle + " #" + IssueNumber;
            }
        }

        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ","-")
                                  .ToLower() + "-" + IssueNumber + ".jpg";
            }
        }
    }
}
