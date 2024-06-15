using UnityEngine;

public class SwordFactory : WeaponFactory
{
    public override IWeapon CreateWeapon(string type)
    {
        return new Sword();
    }
}
