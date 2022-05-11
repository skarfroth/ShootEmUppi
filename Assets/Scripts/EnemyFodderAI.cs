using UnityEngine;

public class EnemyFodderAI : MonoBehaviour
{
    public Rigidbody2D bullet;

    void Start()
    {
        InvokeRepeating("Shoot", 2.0f, 0.3f);
    }

    void Shoot()
    {
        Rigidbody2D clone = Instantiate(bullet, transform.position, Quaternion.identity);
        clone.velocity = Vector2.down * 5;
    }
}
