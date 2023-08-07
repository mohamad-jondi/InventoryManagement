namespace InventoryMangment
{

    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class BaseEntity
    {
        public EntityStateOption EntityOption { get; set; }
        public bool hasChanged { get; set; }
        public bool IsNew { get; private set; }
        public bool IsValid => Validate();

        public abstract bool Validate();
    }   
}