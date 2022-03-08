using UnityEngine;

public class PlayerBulletBehaviour : MonoBehaviour
{
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + Vector2.up * Time.fixedDeltaTime * 5f);
    }
}