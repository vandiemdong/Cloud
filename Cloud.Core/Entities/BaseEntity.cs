namespace Cloud.Core.Entities
{
	public class BaseEntity
	{
		public DateTime? DateCreated { get; set; }
		public DateTime? DateUpdated { get; set; }
		public long? CreatedBy { get; set; }
		public long? UpdatedBy { get; set; }
		public bool IsDeleted { get; set; }
	}
}
