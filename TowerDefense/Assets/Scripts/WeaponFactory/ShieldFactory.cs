public class ShieldFactory : WeaponFactory
{
    public override IWeapon CreateWeapon(string type)
    {
        return new Shield();
    }
}
