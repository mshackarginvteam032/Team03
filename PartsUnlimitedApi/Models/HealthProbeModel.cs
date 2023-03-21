namespace PartsUnlimitedApi.Models
{
    public class HealthProbeModel
    {
        public HealthProbeModel()
        {
            Ready = true;
        }
        public HealthProbeModel(bool readiness)
        {
            Ready = readiness;
        }
        public bool Ready { get; set; }
    }
}
