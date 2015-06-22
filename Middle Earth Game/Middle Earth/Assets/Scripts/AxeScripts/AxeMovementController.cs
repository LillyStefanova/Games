using UnityEngine;
using System.Collections;
public class AxeMovementController : MonoBehaviour
{
    private GameObject player;
    public void Start()
    {
        this.player = GameObject.FindWithTag("Player");
    }

    public void FixedUpdate()
    {
        StartCoroutine("ParabolicMove");
    }

    IEnumerator ParabolicMove()
    {        
        var gravity = new Vector3(0, -0.03f, 0);
        var velocity = Vector3.left;

        if(this.transform.position.x < player.transform.position.x)
        {
            velocity = new Vector3(0.03f, 0.13f, 0);
        }
        else if (this.transform.position.x > player.transform.position.x)
        {
            velocity = new Vector3(-0.03f, 0.13f, 0);
        }

        this.transform.Translate(gravity + velocity);
        yield return null;
    }
}
