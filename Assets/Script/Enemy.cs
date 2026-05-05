using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    public int health = 3;
    public Transform player;

    void Update()
    {
        // เดินไปทางซ้ายตลอด
        transform.position = Vector2.MoveTowards(
        transform.position,
        player.position,
        speed * Time.deltaTime
        );
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}