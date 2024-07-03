namespace Models
{
    public class Computer
    {
        // private string motherboard;
        public int ComputerId { get; set; }
        public string Motherboard { get; set; } = "";
        public int? CPUcores { get; set; }
        public bool HasWifi { get; set; }
        public bool HasLTE { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal price { get; set; }
        public string VideoCard { get; set; } = "";

        public Computer()
        {
            if (VideoCard == null)
            {
                VideoCard = "";
            }
            if (Motherboard == null)
            {
                Motherboard = "";
            }
            if (CPUcores == null)
            {
                CPUcores = 0;
            }
        }
    }
}