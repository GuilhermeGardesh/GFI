namespace GFI.Domain.Commom.Entities
{
    public abstract class Entity
    {
        protected Entity()
        { }

        protected Entity(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; } = default!;
    }
}
