using UnityEngine;
using System.Collections;
public class LevitateController : MonoBehaviour 
{
    public GameObject beam;
    bool statement = false;
	public void Start () 
    {
        
	}

    public void Update()
    {
        
        int sum = OrcDamageController.sum;

        if(sum >= 3 && statement == false)
            {
                StartCoroutine("Elevate");
                Invoke("StartReturning", 6.5f);
            }
      
    }
    public IEnumerator Elevate()
    {
        var position = beam.transform.position;
        while (position.y < 0.45f)
        {
            position.y += 0.2f;

            yield return new WaitForSeconds(1f);
            beam.transform.position = position;
            
        }
    }

    public void StartReturning()
    {
        StartCoroutine("Return");
        statement = true;
    }
    public IEnumerator Return()
    {
         var position = beam.transform.position;
         while (position.y > 0.3f)
         {
             position.y -= 0.2f;

             yield return new WaitForSeconds(1f);
             beam.transform.position = position;
         }
            
    }

}
