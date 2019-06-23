using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeForestBackend.Models
{
    public class Faculty : TableEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public Faculty()
        {

        }
        public Faculty(string name, string title, string email, string picture)
        {
            this.PartitionKey = "Faculty";
            this.RowKey = name;
            this.Name = name;
            this.Title = title;
            this.Email = email;
            this.Picture = picture;
        }
    }
}
