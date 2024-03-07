using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILLING_SYSTEM.Models
{
    public class HomeOwners
    {
        int homeOwnerId;
        string fullName;
        string contactNo;
        string email;
        string phaseName;
        string block;
        string lot;
        DateTime moveInDate;
        DateTime created_at;

        public int HomeOwnerId { get => homeOwnerId; set => homeOwnerId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string ContactNo { get => contactNo; set => contactNo = value; }
        public string Email { get => email; set => email = value; }
        public string PhaseName { get => phaseName; set => phaseName = value; }
        public string Block { get => block; set => block = value; }
        public string Lot { get => lot; set => lot = value; }
        public DateTime MoveInDate { get => moveInDate; set => moveInDate = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
    }
}
