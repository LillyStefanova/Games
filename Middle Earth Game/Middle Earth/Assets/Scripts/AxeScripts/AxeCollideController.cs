using UnityEngine;
using System.Collections;

public class AxeCollideController : MonoBehaviour
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
        if (this.gameObject.name != "Axe")
        {
            if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Player")
            {
                Destroy(this.gameObject);
            }

            if (collision.gameObject.tag == "Lath" || collision.gameObject.tag == "Beam")
            {
                var scale = this.gameObject.transform.localScale;
                scale.x = -1 * scale.x;
                this.gameObject.transform.localScale = scale;
            }
        }
    }
}



