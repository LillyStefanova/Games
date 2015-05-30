using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 
{
    public GameObject bagira;

    private float offset;
	void Start ()
    {
        this.offset = this.transform.position.x - bagira.transform.position.x;
       
	}
	void Update () 
    {
        var position = this.transform.position;
        if(bagira.transform.position.x > 3.8 && bagira.transform.position.x < 11.5)
        {       
         position.x = bagira.transform.position.x;        
         this.transform.position = position;
        }
	}
}
