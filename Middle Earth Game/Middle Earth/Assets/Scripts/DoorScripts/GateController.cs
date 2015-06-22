using UnityEngine;
using System.Collections;

public class GateController : MonoBehaviour 
{
    public AudioClip hatchDoor;
    public AudioClip victorySound;
    private Animator anim;
    private Collider2D collision;
    private AudioSource audioSource;
	public void Start () 
    {
        this.anim = this.GetComponent<Animator>();
        this.collision = this.GetComponent<Collider2D>();
        this.audioSource = this.GetComponent<AudioSource>();
	}
	public void Update () 
    {
        this.anim.enabled = false;
        var coins = GameObject.FindWithTag("Coin");
        var orcs = GameObject.FindWithTag("Enemy");
        if(coins == null && orcs == null)
        {
            this.anim.enabled = true;
        }

        OnTriggerStay2D(collision);
	}

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (Application.loadedLevelName != "ThirdLevel")
        {
            if (collision.gameObject.tag == "Player" && anim.enabled)
            {
                audioSource.PlayOneShot(hatchDoor);
                Application.LoadLevel("SecondLevel");
            }
        }
        if(Application.loadedLevelName == "ThirdLevel")
        {
            if (collision.gameObject.tag == "Player" && anim.enabled)
            {
                audioSource.PlayOneShot(victorySound);
                Application.LoadLevel("Win");
            }
        }
    }
}
