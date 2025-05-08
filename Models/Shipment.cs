namespace FreightTrackerLegacy.Models
{
	public class Shipment
	{
		public int Id { get; set; }
		public string Destination { get; set; } = string.Empty;
		public string Status { get; set; } = "Pending";
		public DateTime Date { get; set; }
	}
}
