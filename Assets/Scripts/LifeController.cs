using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeController : MonoBehaviour
{
    public int lifes_current;
    public int lifes_max;
    public float invencible_time;
    bool invencible;

    Rigidbody2D rb;

    public enum DeathMode { Teleport, RealoadScene, Destroy }
    public DeathMode death_mode;
    public Transform respawn;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lifes_current = lifes_max;
    }

    public void Damage(int damage = 1, bool IgnoreInvencible = false)
    {
        if(!invencible || IgnoreInvencible)
        {
            lifes_current -= damage;
            StartCoroutine(Invencible_Corutine());
            if(lifes_current <= 0)
            {
                Death();
            }
        }
    }

    public void Death()
    {

        switch (death_mode)
        {
            case DeathMode.Teleport:
                rb.velocity = new Vector2(0, 0);
                transform.position = respawn.position;
                lifes_current = lifes_max;
                break;
            case DeathMode.RealoadScene:          
                break;
            case DeathMode.Destroy:
                Destroy(gameObject);
                break;
            default:
                break;
        }
    }

    IEnumerator Invencible_Corutine()
    {
        invencible = true;
        yield return new WaitForSeconds(invencible_time);
        invencible = false;
    }
}
