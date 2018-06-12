namespace FlightFinder.Types
{
    public class FlightStatusDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
