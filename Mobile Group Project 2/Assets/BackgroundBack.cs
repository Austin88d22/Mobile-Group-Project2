using UnityEngine;
public class BackgroundBack : MonoBehaviour
{
    public float speed;
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = -transform.right * speed;
    }
}
