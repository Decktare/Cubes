using UnityEngine;

public class Cube : MonoBehaviour
{
    private Rigidbody cube;

    public float speed;
    public float deadRange;

    private void Start()
    {
        cube = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        cube.velocity = transform.up * speed * Time.fixedDeltaTime;
        if (transform.position.y > deadRange)
        {
            Destroy(this.gameObject);
        }
    }
}
