using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderEnemy : MonoBehaviour
{

    public float Ranger;

    public Transform Target;

    bool Detected = false;

    Vector2 Direction;

    public GameObject AlaramLight;

    public GameObject AlaramLight1;

    public GameObject Gun;

    public GameObject Bullet;

    public float FireRate;

    float nextTimeFire=0;
    public Transform ShootPoint;

    public float Force;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targetPos = Target.position;
        Direction = targetPos - (Vector2)transform.position;
        RaycastHit2D rayInfo = Physics2D.Raycast(transform.position, Direction, Ranger);

        if (rayInfo)
        {
            if (rayInfo.collider.gameObject.tag == "player")
            {
                if (Detected == false)
                {
                    Detected = true;
                    AlaramLight.GetComponent<SpriteRenderer>().color = Color.red;
                    AlaramLight1.GetComponent<SpriteRenderer>().color = Color.red;

                }
            }
            else
            {
                if (Detected == true)
                {
                    Detected = false;
                    AlaramLight.GetComponent<SpriteRenderer>().color = Color.yellow;
                    AlaramLight1.GetComponent<SpriteRenderer>().color = Color.yellow;
                }
            }
        }
        if (Detected)
        {
            Gun.transform.up = Direction;
            if(Time.time > nextTimeFire)
            {
                nextTimeFire = Time.time +1/FireRate;
                shoot();
            }
        }
    }

    void shoot()
    {
      GameObject BulletIns = Instantiate(Bullet, ShootPoint.position,Quaternion.identity);
       // BulletIns.GetComponents<Rigidbody2D>().AddForce(Direction * Force); 
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, Ranger);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }

}
