using UnityEngine;
using System.Collections;

public class ContainDataController : MonoBehaviour
{
    public int id;
    string playerPrefsString;
    public void Awake()
    {
        playerPrefsString = Application.loadedLevelName + "/" + id;
        if (PlayerPrefs.GetInt(playerPrefsString) != 0)
        {
            Destroy(gameObject);
        }

        if (Application.loadedLevelName == "Fiesta!")
        {
            PlayerPrefs.DeleteAll();
        }
        Die();
    }

    public void Die()
    {
        PlayerPrefs.SetInt(playerPrefsString, 1);
    }
}
