using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Transform playerPos;
    private Vector2 currentPos;
    [SerializeField] private float distance;
    [SerializeField] private float speed;
    // Start is called before the fir
    // st frame update
    void Start()
    {
        playerPos = player.GetComponent<Transform>();
        currentPos = GetComponent<Transform>().position;
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        enemystand();
    }

    public void enemystand()
    {
        if (Vector2.Distance(transform.position, playerPos.position) < distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
        }
        else
        {
            if (Vector2.Distance(transform.position, currentPos) <= 0)
            {

            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, currentPos, speed * Time.deltaTime);
            }
        }
    }
}
