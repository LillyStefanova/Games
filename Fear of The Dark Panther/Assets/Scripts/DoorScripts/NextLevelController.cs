using UnityEngine;
using System.Collections;
public class NextLevelController : MonoBehaviour 
{
    public AudioClip hatchSound;

    private AudioSource audioSource;
    private Collider2D collision;
    private Animator animator; 
	public void Start () 
    {
        this.collision = this.GetComponent<Collider2D>();
        this.animator = this.GetComponent<Animator>();
        this.audioSource = this.GetComponent<AudioSource>();
	}
	
	public void Update () 
    {        
        OnTriggerStay2D(collision);       
	}
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bagira")
        {
            if (this.animator.enabled == true)
            {
                this.audioSource.PlayOneShot(hatchSound);
                StartCoroutine(NextLevel());                
            }
        }
    }
    
    IEnumerator NextLevel()
    {
         
         yield return new WaitForSeconds(1.5f);
        
         if (Application.loadedLevel != 4)
         {            
             Application.LoadLevel(Application.loadedLevel + 1);
             
         }
         else
         {
             Application.LoadLevel("Win");
         }
    }
}
