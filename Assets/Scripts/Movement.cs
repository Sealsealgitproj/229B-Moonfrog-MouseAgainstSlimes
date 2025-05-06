using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    float move;

    public float jumpforce;
    public bool isJumping;
    
    Rigidbody2D rb2d;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        rb2d.linearVelocity = new Vector2(move * speed, rb2d.linearVelocity.y);
        
        if (Input.GetButton("Jump"))
        {
            rb2d.AddForce(new Vector2(rb2d.linearVelocity.x, jumpforce));
            Debug.Log("Jump"); 
    }
}
    
}

