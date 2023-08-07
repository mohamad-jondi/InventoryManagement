namespace InventoryMangment
{

    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    internal abstract class BaseEntity
    {
        public EntityStateOption EntityOption { get; set; }
        public bool hasChanged { get; set; }
        public bool IsNew { get; private set; }
        public bool IsValid { get; protected set; }

        public abstract bool Validate();
    }   
}