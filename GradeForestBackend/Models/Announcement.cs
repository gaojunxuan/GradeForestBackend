using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeForestBackend.Models
{
    public class Announcement : TableEntity
    {
        public string Title { get; set; }
        public string Poster { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public Announcement()
        {

        }
        public Announcement(string title, string poster, string content, string image, DateTime date)
        {
            this.PartitionKey = "Announcement";
            this.RowKey = Guid.NewGuid().ToString();
            this.Poster = poster;
            this.Title = title;
            this.Content = content;
            this.Image = image;
            this.Date = date;
        }
    }
}
