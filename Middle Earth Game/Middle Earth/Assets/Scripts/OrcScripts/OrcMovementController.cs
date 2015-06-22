using UnityEngine;
using System.Collections;

public class OrcMovementController : MonoBehaviour
{
    public GameObject axe;
    public Transform player;
    public float speed = 1.5f;    

    private Animator anim;
    private GameObject[] axes;
    private GameObject[] orcs;
    public void Start()
    {
        this.anim = this.GetComponent<Animator>();
    }
    public void Update()
    {
        this.axes = GameObject.FindGameObjectsWithTag("Axe");
        this.orcs = GameObject.FindGameObjectsWithTag("Enemy");
        int count = orcs.Length;
        int length = axes.Length - 1;
        int sign = 1;
        var scale = this.transform.localScale;
        anim.SetInteger("OrcState", 0);
        
        if (player.transform.position.y <= this.transform.position.y + 0.5f)
        {
            if (player.transform.position.x + 1.5f < this.transform.position.x)
            {
                sign = -1;
                if (scale.x > 0)
                {
                    scale.x *= -1;
                }
            }

            else if (player.transform.position.x - 1.5f > this.transform.position.x)
            {
                sign = 1;
                if (scale.x < 0)
                {
                    scale.x *= -1;
                }
            }            
           
            if (Vector3.Distance(this.transform.position, player.position) > 2.5f)
            {
                anim.Play("OrcWalk");
                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0) * sign);
            }
            if (Vector3.Distance(this.transform.position, player.position) <= 2.5f && Vector3.Distance(this.transform.position, player.position) > 1f)
            {
                var axePosition = this.transform.position;
                axePosition = DefinateAxeStartPosition(axePosition);

                if (length < count)
                {
                    for (int i = 0; i < count; i++)
                    {
                       // Instantiate(axe, axePosition, Quaternion.identity);
                        StartCoroutine(InstantiateAxe(axePosition));
                    }
                }                 
            }
            

            this.transform.localScale = scale;
        }
    }

    public Vector3 DefinateAxeStartPosition(Vector3 axePosition)
    {
        if (this.transform.localScale.x < 0)
        {
            axePosition.x -= 0.5f;
            axePosition.y += 0.5f;
        }
        else
        {
            axePosition.x += 0.5f;
            axePosition.y += 0.5f;
        }
        return axePosition;
    }

    IEnumerator InstantiateAxe(Vector3 axePosition)
    {
        Instantiate(axe, axePosition, Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
    }

}