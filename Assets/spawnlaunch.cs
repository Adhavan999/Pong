using UnityEngine;

public class spawnlaunch : MonoBehaviour {

    Rigidbody2D rb;
    public float launchspeed;

	void Start () {

        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2((Random.value > 0.5f)? -launchspeed: launchspeed, (Random.value > 0.5f) ? -launchspeed : launchspeed);
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity = Vector2.Scale(rb.velocity, new Vector2(1.01f, 1.01f));
    }
}
