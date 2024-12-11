using UnityEngine;

public class Attack : MonoBehaviour
{

    public int damage;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //PlayerController player = collision.GetComponent<PlayerController>();

        //EnemyController enemy = collision.GetComponent<EnemyMeleeController>();

        //if (player != null)
        //{
        //    player.TakeDamage(damage);
        //}

        //if (enemy != null)
        //{
        //    enemy.TakeDamage(damage);
        //}


    }
}
