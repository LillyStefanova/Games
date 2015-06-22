using UnityEngine;
using System.Collections;

public class BigController : MonoBehaviour
{
    private Collider2D collision;
    public void Start()
    {
        this.collision = this.GetComponent<Collider2D>();
    }
    public void Update()
    {
        OnTriggerEnter2D(collision);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {          
               
                var player = collision.gameObject;
                var scale = player.transform.localScale;
                if (scale.y == 0.5f)
                {
                    scale.x = -1f;
                    scale.y = 1f;
                    player.transform.localScale = scale;
                    Destroy(this.gameObject);
                }
        }
    }
}

