using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag == "player")
        {
           HealthBar.instance.AfterDamagehealth();
        }
        Destroy(this.gameObject);
    }
}
