using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeForestBackend.Models
{
    public class BasicInformation : TableEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string StationCode { get; set; }
        public BasicInformation()
        {

        }
        public BasicInformation(string key, string name, string location, string description, string image, string stationCode)
        {
            this.PartitionKey = "BasicInfo";
            this.RowKey = key;
            this.Name = name;
            this.Location = location;
            this.Description = description;
            this.Image = image;
            this.StationCode = stationCode;
        }
    }
}
