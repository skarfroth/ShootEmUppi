public class PlayerBulletBehaviour : MonoBehaviour
{
    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + Vector2.up * Time.fixedDeltaTime * 5f);
    }
}