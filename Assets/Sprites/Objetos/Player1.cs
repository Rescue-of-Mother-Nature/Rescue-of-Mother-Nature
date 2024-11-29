using UnityEngine;

public class Player1 : MonoBehaviour
{

    private Rigidbody2D playerRigidBody2D;



    public float playerSpeed = 1.0f;

    public Vector2 playerDirection;

    private Animator playerAnimation;

    private bool playerFacingRight = true;

    private bool isWalking;


    void Start()
    {
        playerRigidBody2D = GetComponent<Rigidbody2D>();
    }



   
    void Update()
    {
        player1Move();
    }

    void FixedUpdate()
    {
        if (playerDirection.x != 0 || playerDirection.y != 0)
        {
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }


        playerRigidBody2D.MovePosition(playerRigidBody2D.position + playerSpeed * Time.fixedDeltaTime * playerDirection);
    }

    void player1Move()
    {
        playerDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (playerDirection.x < 0 && playerFacingRight)
        {
            Flip();
        }
        else if (playerDirection.x > 0 && !playerFacingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        playerFacingRight = !playerFacingRight;

        transform.Rotate(0,180,0);
    }
}
