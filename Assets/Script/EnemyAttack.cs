using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float damageCooldown = 1f;
    private float lastHitTime;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Time.time > lastHitTime + damageCooldown)
            {
                other.GetComponent<PlayerHealth>().TakeDamage(1);
                lastHitTime = Time.time;
            }
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
