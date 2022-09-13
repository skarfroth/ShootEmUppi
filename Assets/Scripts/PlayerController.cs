public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;

    private float cooldownEndtime = 0f;
    private float shootCooldown = 0.2f;
    private Rigidbody2D rb2d;
    private Vector2 movementVector;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        movementVector.x = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Space))
        {
            if (Time.time >= cooldownEndtime)
            {
                cooldownEndtime = Time.time + shootCooldown;
                Shoot();
            }
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
            bullet.transform.position = transform.position;
            bullet.SetActive(true);
        }
    }
}
