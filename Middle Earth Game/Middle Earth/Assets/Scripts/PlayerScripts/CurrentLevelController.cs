using UnityEngine;
    public class CurrentLevelController : MonoBehaviour
    {
        public static int currentLevel;
        public void Update()
        {
            CurrentLevel();
        }
        public int CurrentLevel()
        {
            currentLevel = Application.loadedLevel;
            return currentLevel;
        }
    }