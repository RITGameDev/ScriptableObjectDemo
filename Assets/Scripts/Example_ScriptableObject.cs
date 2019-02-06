using UnityEngine;

public enum EGunType
{
    rifle,
    pistol,
    grenade,
    sniper
}

[CreateAssetMenu(fileName = "Weapons", menuName = "Gun Type")]
public class Example_ScriptableObject : ScriptableObject
{
    public EGunType GunType;

    public CompleteDemo.PickupItem AmmoType;

    [Range(1, 10)]
    public int damage = 10;

    public Material gunMat;
}