using UnityEngine;
using System.Collections;

public class BeamScript : MonoBehaviour 
{
    public GameObject beam;
    public GameObject secondBeam;

    private Collider2D collision;
	public void Start () 
    {
        this.collision = this.GetComponent<Collider2D>();
        beam = GameObject.Find("Beam 1");
        secondBeam = GameObject.Find("Beam 2");
	}
	
	public void Update () 
    {
        OnTriggerStay2D(collision);
	}

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bagira")
        {
                StartCoroutine("Slide");
                StartCoroutine("Elevate");
        }
    }
    
    public IEnumerator Elevate()
    {
        
        var position = beam.transform.position;
        while (position.y < 3f)
        {
            position.y += 0.3f;
            yield return new WaitForSeconds(1f);
            beam.transform.position = position;
        }
    }

    public IEnumerator Slide()
    {
        var position = secondBeam.transform.position;
        while (position.y > 2.589f)
        {
            position.y -= 0.3f;
            yield return new WaitForSeconds(1f);
            secondBeam.transform.position = position;
        }
    }
}
