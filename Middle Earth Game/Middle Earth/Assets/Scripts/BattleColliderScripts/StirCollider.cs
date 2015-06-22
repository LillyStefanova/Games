using UnityEngine;
using System.Collections;

public class StirCollider : MonoBehaviour
{
    public GameObject player;

    private Collider2D collision;
    private bool isControlPressed = false;
    public void Start()
    {
        this.collision = this.GetComponent<Collider2D>();
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            isControlPressed = true;
        }

        var scale = player.transform.localScale;
        float sign = 1;
        if (scale.x > 0)
        {
            sign = 1.3f;
        }

        if (scale.x < 0)
        {
            sign = -1.3f;
        }

        var position = this.transform.position;
        position.x = player.transform.position.x + sign;
        position.y = player.transform.position.y + 0.61f;
        this.transform.position = position;

        OnTriggerStay2D(collision);

    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && isControlPressed)
        {
            isControlPressed = false;
            var health = collision.gameObject.GetComponent<OrcDamageController>();
            health.TakeLives();
        }
    }
}
