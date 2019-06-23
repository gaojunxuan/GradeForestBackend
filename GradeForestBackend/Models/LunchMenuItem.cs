using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeForestBackend.Models
{
    public class LunchMenuItem : TableEntity
    {
        public string Main { get; set; }
        public string Side { get; set; }
        public double Calories { get; set; }
        public LunchMenuItem()
        {

        }
        public LunchMenuItem(string day, string main, string side, double cal)
        {
            this.PartitionKey = "Lunch";
            this.RowKey = day;
            this.Main = main;
            this.Side = side;
            this.Calories = cal;
        }
    }
}
