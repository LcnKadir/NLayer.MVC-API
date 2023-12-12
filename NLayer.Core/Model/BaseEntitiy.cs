namespace NLayer.Core.Model
{
    public abstract class BaseEntitiy
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
