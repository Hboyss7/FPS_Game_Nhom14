using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    public int ammoAmout = 200;
    public AmmoType ammoType;

    public enum AmmoType
    {
        RifleAmmo,
        PistolAmmo
    } 
        
}
