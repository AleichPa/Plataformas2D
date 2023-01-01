using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenByDiamonds : MonoBehaviour
{
    public Transform door, open, close, diamonds;
    public float speed;
    bool isEnter;
    // Update is called once per frame
    void Update()
    {
        door.transform.position = Vector2.MoveTowards(door.transform.position, (isEnter && diamonds.childCount == 0) ? open.position : close.position, speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            isEnter = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            isEnter = false;
        }
    }
}
