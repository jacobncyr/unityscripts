using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : MonoBehaviour
{

    [SerializeField] private GameObject weaponLogic;
    // Start is called before the first frame update
   public void EnableWeapon()
    {
        weaponLogic.SetActive(true);
    }
    
   public void DisableWeapon()
    {
        weaponLogic.SetActive(false);
    }
}
