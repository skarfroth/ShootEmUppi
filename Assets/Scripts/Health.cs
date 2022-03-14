using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] public float maxHealth = 100f;
    public float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void TakeDamage(float amount)
    {
        currentHealth -= amount;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerBullet") && this.CompareTag("Enemy"))
        {
            TakeDamage(50f);
            other.gameObject.SetActive(false);
        }
    }
}
