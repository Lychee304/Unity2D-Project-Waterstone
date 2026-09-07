using Unity.VisualScripting;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{
    public GameObject weaponPickUp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Weapon")
        {
            
        }
    }
}
