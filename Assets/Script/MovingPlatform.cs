using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;
    public int startingPoint;
    public Transform[] points; //array of transform point

    private int i;
    private void Start()
    {
       transform.position = points[startingPoint].position;
    }

    private void Update()
    {
        //Checing the distance of the platform ND THE POINT
        if(Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {
            i++;//increase the index
            if(i == points.Length) //check if the platform was on the last point after the index increase
            {
                i=0; //reset the index
            }
        }
       transform.position = Vector2.MoveTowards(transform.position, points[i].position,speed *Time.deltaTime);
    }
}
