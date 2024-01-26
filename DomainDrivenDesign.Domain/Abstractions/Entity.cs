public abstract class Entity :IEquatable<Entity> // abstract class cunku newlenmesini istemiyoruz,sadece kalitim alinmasini istiyoruz
{
    public Guid Id { get; init; } // init ile set edilebilir ama constructor disinda set edilemez hale getiriyoruz

    public Entity(Guid id)
    {
        Id = id;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        if(obj is not Entity entity)
            return false;

        return Id == entity.Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public bool Equals(Entity? other)
    {
        if (other == null || GetType() != other.GetType())
            return false;

        if(other is not Entity entity)
            return false;

        return Id == entity.Id;
    }
}


