public class BowFactory : WeaponFactory
{
    public override IWeapon CreateWeapon(string type)
    {

        if (type == "weak") {
            return new ShortBow();
        }
        else if (type == "normal")
        {
            return new Bow();
        }
        else if (type == "strong")
        {
            return new Ballista();
        }
        else
            return null;        
    }
}
