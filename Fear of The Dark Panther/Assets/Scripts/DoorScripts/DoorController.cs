using UnityEngine;
public class DoorController : MonoBehaviour 
{    
    private Animator animator;        
	public void Start () 
    {
        this.animator = this.GetComponent<Animator>();
	}
	
	public void Update () 
    {
        this.animator.enabled = false;
        var food = GameObject.FindWithTag("Food");
        if (food == null)
        {
            this.animator.enabled = true;           
        }
	}
}









