using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTarget : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
        
        Destroy(gameObject);
        Destroy(other.gameObject);
        
        }



    }
}
