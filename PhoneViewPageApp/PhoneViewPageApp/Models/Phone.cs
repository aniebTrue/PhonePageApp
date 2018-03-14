using System;

namespace PhoneViewPageApp.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string Processor { get; set; }
        public int Cores { get; set; }
        public double RAMSizeMB { get; set; }
        public double MemerySizeMB { get; set; }
        public Nullable<double> CameraMP { get; set; }
        public string PhoneIMGName { get; set; }
    }
}