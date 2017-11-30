using System;

namespace EAS.Entities
{
    class Patient : User
    {
        public new int Uid { get; set; }
        public string PName { get; set; }
        public DateTime PDOB { get; set; }
        public string PMobileNo { get; set; }
        public string PEmail { get; set; }
        public string PGenger { get; set; }
        public string PAdress { get; set; }
        public float PLat { get; set; }
        public float PLng { get; set; }
        public string PBloodGrp { get; set; }
        public bool PDiabetes { get; set; }
        public string PBloodSugar { get; set; }
        public bool PPressure { get; set; }
        public string PAvgPressure { get; set; }
    }
}
