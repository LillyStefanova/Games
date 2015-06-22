using UnityEngine;
public class PassController : MonoBehaviour
{
    public GameObject player;
    public AudioClip hatchDoor;
       
    private Collider2D collision;
    private AudioSource audioSource;
    private int sum;
    public void Start()
    {
        this.collision = this.GetComponent<Collider2D>();
        this.audioSource = this.GetComponent<AudioSource>();
    }
    public void Update()
    {
        sum = OrcDamageController.sum;
        OnTriggerStay2D(collision);
    }
    public void OnTriggerStay2D(Collider2D collision)
    {       
        if (collision.gameObject.tag == "Player")
        {           
            if (sum >= 3)
            {
                audioSource.PlayOneShot(hatchDoor);
                Application.LoadLevel("FirstLevel");
            }
        }
    }
}
