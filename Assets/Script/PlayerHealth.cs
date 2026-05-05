using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 5;
    public GameObject gameOverPanel;

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
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f; // หยุดเกม
        Destroy(gameObject);
    }
}