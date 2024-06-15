using UnityEngine;
public class Soldier : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BowFactory bowFactory = new BowFactory();
        IWeapon bow = bowFactory.GetWeapon("weak"); 

        SwordFactory swordFactory = new SwordFactory();
        IWeapon sword = swordFactory.GetWeapon("normal");

        ShieldFactory shieldFactory= new ShieldFactory();
        IWeapon shield = shieldFactory.GetWeapon("normal");   

    }
}
