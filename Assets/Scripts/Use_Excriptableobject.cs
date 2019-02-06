using UnityEngine;

public class Use_Excriptableobject : MonoBehaviour
{
    public Example_ScriptableObject Gun;


    void Update()
    {      
        if(Input.GetKeyDown(KeyCode.A))
        {
            switch(Gun.GunType)
            {
                case EGunType.grenade:
                    Debug.Log("BOOM");
                    break;

                case EGunType.rifle:
                    Debug.Log("<color=red>BANG BOI</color>");
                    break;

                default:
                    break;
            }
        }
    }
}
