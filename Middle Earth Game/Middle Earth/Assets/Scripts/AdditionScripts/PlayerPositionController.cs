using UnityEngine;

public class PlayerPositionController : MonoBehaviour
{
    private int level;

    public void Start()
    {
        level = CurrentLevelController.currentLevel;
    }
    public void Update()
    {
        var position = this.transform.position;
        switch (level)
        {
            case 2:
                {
                    position.x = 276f;
                    position.y = 58f;
                } break;

            case 3:
                {
                    position.x = 301f;
                    position.y = 116f;

                } break;
            case 4:
                {
                    position.x = 254f;
                    position.y = 182f;

                } break;

            case 5:
                {
                    position.x = 191f;
                    position.y = 185.5f;

                } break;

            default:
                {
                    position.x = 208f;
                    position.y = 44f;
                } break;
        }

        this.transform.position = position;
    }
}
