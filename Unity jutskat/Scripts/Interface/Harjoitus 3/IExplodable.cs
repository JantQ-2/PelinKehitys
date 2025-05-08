
public interface IExplodable
{
    public int Mass { get; set; }
    public int ExplosiveForce { get; set; }
    public int FuseDelay { get; set; }

    public void Explode();
}