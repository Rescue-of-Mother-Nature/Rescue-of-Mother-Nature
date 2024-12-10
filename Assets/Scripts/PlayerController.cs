using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variavel que controla o animador do player
    private Animator playerAnimator;

    // variavel de trigger de animação
    private bool isWalking;

    // variavel para o personagem olhar para o lado certo
    private bool isFacingRight = true;

    // variavel para controlar o rigidBody (usado para movimentação do player)
    private Rigidbody2D playerRigidbody;

    // variaveis auxiliares para movimentação do player
    public Vector2 playerDirection;
    private float maxSpeed = 1f;
    private float currentSpeed;

    // variaveis para contagem de vida
    public int maxHealth = 100;
    public int currentHealth;

    // variaveis para sprite do personagem
    public Sprite playerImage;



    void Start()
    {
        // pegando o Animator e RigidBody do player
        playerAnimator = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody2D>();

        // setando a velocidade e vida atual com base em suas maximas
        currentSpeed = maxSpeed;

    }

    
    void Update()
    {
        // atualizando a movimentação do player
        PlayerMove();
        // atualizando a animação da movimentação do player


    }

    void FixedUpdate()
    {
        // definindo se o personagem está andando ou não, Para atualizar a animação
        if (playerDirection.x != 0 || playerDirection.y != 0)
        {
            isWalking = true;
        }
        else
        {
            isWalking= false;
        }

        // finalmente movimentando o personagem, adicionando a ele a velocidade atual com uma matematica
        playerRigidbody.MovePosition(playerRigidbody.position + currentSpeed * Time.fixedDeltaTime * playerDirection);

    }

    void PlayerMove()
    {
        // recebendo qual tecla o Jogador esta clicando e adicionando ao PlayerDirection
        playerDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        // ativando função de flipar dependendo de qual lado ele esta olhando
        if (playerDirection.x < 0 && isFacingRight)
        {
            Flip();
        }
        else if (playerDirection.x > 0 && !isFacingRight)
        {
            Flip();
        }
    }
    
    // Função para virar o inimigo para o lado oposto
    void Flip()
    {
        isFacingRight = !isFacingRight;

        transform.Rotate(0,180,0);
    }


}
