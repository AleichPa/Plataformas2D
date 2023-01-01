using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed;
    public Transform detect;
    public LayerMask wallMask;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(transform.right.x * speed, rb.velocity.y);

        Collider2D collision = Physics2D.OverlapCircle(detect.position, 0.1f, wallMask);
        if (collision != null)
        {
            transform.eulerAngles = transform.eulerAngles.y == 0 ? new Vector3(0, 180, 0) : new Vector3(0, 0, 0);
        }
    }
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
