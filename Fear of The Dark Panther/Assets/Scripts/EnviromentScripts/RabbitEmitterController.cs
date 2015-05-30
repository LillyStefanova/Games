using UnityEngine;
public class RabbitEmitterController : MonoBehaviour
{
    public GameObject rabbit;   
    public Vector3 position;

    public void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            position = new Vector3(Random.Range(1.4f, 14.3f), Random.Range(0.6f, 5f), 0);
            Instantiate(rabbit, position, this.transform.rotation);
        }
    }    
}