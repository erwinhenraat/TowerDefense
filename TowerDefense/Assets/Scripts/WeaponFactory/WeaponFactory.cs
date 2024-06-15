public abstract class WeaponFactory
{
    private string _type;
    public abstract IWeapon CreateWeapon(string type);//factory method
    public IWeapon GetWeapon(string type) {//some operation

        _type = type;
        IWeapon weapon = CreateWeapon(_type);
        weapon.DoStuff();
        return weapon;
    }    
}
