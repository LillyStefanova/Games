using UnityEngine;
public class TeleportScript : MonoBehaviour
{
    public AudioClip teleport;

    private Collider2D collision;
    private AudioSource audioSource;
    public void Start()
    {
        this.audioSource = this.GetComponent<AudioSource>();
        this.collision = this.GetComponent<Collider2D>();
    }


    public void Update()
    {
        OnTriggerEnter2D(collision);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Bagira")
        {
            var position = collision.gameObject.transform.position;
            //position.x = 13.5f;
            //position.y = 4f;
            if (Application.loadedLevel == 2)
            {
                position.x = 4f;
                position.y = 4.4f;
            }
            if (Application.loadedLevel == 3)
            {
                position.x = 11.4f;
                position.y = 4f;
            }
            this.audioSource.PlayOneShot(teleport);
            collision.gameObject.transform.position = position;
        }
    }
}
