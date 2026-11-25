namespace GymManagementSystem.Entities
{
    public class Session : BaseEntity
    {
        public string description { get; set; }
        public int capacity { get; set; }
        public DateTime startTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; } = default!;

    }
}
