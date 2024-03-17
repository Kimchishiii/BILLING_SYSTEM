using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILLING_SYSTEM.Models
{
    public class GenerateReading
    {
        int homeOwnerId;
        string fullName;
        string phaseName;
        string block;
        string lot;
        DateTime lastReading;
        decimal previousReading;
        decimal currentReading;
        string waterServiceStatus;
        decimal variance;
        decimal totalAmount;
        public int HomeOwnerId { get => homeOwnerId; set => homeOwnerId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string PhaseName { get => phaseName; set => phaseName = value; }
        public string Block { get => block; set => block = value; }
        public string Lot { get => lot; set => lot = value; }
        public DateTime LastReading { get => lastReading; set => lastReading = value; }
        public decimal PreviousReading { get => previousReading; set => previousReading = value; }
        public string WaterServiceStatus { get => waterServiceStatus; set => waterServiceStatus = value; }
        public decimal CurrentReading { get => currentReading; set => currentReading = value; }
        public decimal Variance { get => variance; set => variance = value; }
        public decimal TotalAmount { get => totalAmount; set => totalAmount = value; }
    }
}
