using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;

    private Rigidbody2D rb2d;
    private Vector2 movementVector;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementVector.x = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void FixedUpdate()
    {
        rb2d.velocity = movementVector * movementSpeed;
    }

    private void Shoot()
    {
        GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
            bullet.SetActive(true);
        }
    }
}
