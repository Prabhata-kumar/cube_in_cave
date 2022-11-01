using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float Speed;
    [SerializeField] private float Jump;
    [SerializeField] private ScoreController ScoreController;  

    private void Start()
    {
       rb=GetComponent<Rigidbody2D>(); 
    }
    public void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
      
        MoveCharacter(horizontal);
        PlayMovement(horizontal);
        
    }

    public void MoveCharacter(float horizontal)
    {
        //move the character in horizontaly
        Vector3 position = transform.position;
        position.x += horizontal * Speed * Time.deltaTime;
        transform.position = position;
    }
    public void PlayMovement(float horizontal)
    {
                                           //running
                                           //speed = Input.GetAxisRaw("Horizontal");//it desplay the the speed of a player = 1
                                           // animator.SetFloat("speed", Mathf.Abs(horizontal)); //in it real value
        Vector3 scale = transform.localScale ;//it is take the value from -x site it halp toward left site  
                                           //(distance/sec)*(sec/30)
       if (horizontal > 0) scale.x = 1f*Mathf.Abs(scale.x);
       else if (horizontal < 0) scale.x = -1f * Mathf.Abs(scale.x);
       transform.localScale = scale;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.002f)
        {
            rb.AddForce(new Vector2(0, Jump),ForceMode2D.Impulse);
        }
    }

    //coin destroy
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag =="coin")
        {
            PickUpCoin();
            Destroy(other.gameObject);
        }
    }
    public void PickUpCoin()
    {
        ScoreController.IncreaseScore(10);
    }

}
