namespace kiemtra_nqtk18b.Model
{
	public class IProduct : BaseEntity
	{
		public string Name { get; set; }
		public string Code { get; set; }
		public double Price { get; set; }
		public Boolean? Continue { get; set; }
		public int CategoryId { get; set; }

	}
}
