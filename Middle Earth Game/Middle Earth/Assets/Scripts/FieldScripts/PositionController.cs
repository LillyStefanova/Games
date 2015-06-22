using UnityEngine;

public class PositionController : MonoBehaviour
{
    private GameObject cam;

    void Start()
    {
        this.cam = GameObject.FindWithTag("MainCamera");
    }

    void Update()
    {
        var position = this.transform.position;
        var cameraPosition = cam.transform.position;
        if (this.gameObject.tag == "ScoreText")
        {
            position.x = cameraPosition.x - 1;
            position.y = cameraPosition.y + 1;
        }
        if(this.gameObject.tag == "HealthText")
        {
            position.x = cameraPosition.x + 0.5f;
            position.y = cameraPosition.y + 1;
        }

        this.transform.position = position;
    }
}
