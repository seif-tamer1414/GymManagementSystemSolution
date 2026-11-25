using System.Collections.Specialized;

namespace GymManagementSystem.Entities
{
    public class MemberShip : BaseEntity
    {
        public int MemberId { get; set; }
       
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Member Member { get; set; } = default!;
        public Plan Plan { get; set; } = default!;
        public int PlanId { get; set; }
        public string status => StartDate > DateTime.Now ? "UpComing" : EndDate > DateTime.Now ? "Active" : "Expired";
    }
}
