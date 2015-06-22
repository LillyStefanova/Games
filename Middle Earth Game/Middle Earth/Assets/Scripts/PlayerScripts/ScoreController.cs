using UnityEngine;
using UnityEngine.UI;
public class ScoreController : MonoBehaviour
{

    public static int score;
    public GameObject coin;
    public Text text;
    public AudioClip coinSound;

    private Collider2D collision;
    private AudioSource audioSource;

    public void Start()
    {
        this.text = text.GetComponent<Text>();
        this.audioSource = this.GetComponent<AudioSource>();
        this.collision = this.GetComponent<Collider2D>();       
        UpdateScore();

        if(Application.loadedLevelName == "Fiesta!")
        {
            score = 0;
        }
    }
    public void Update()
    {
        UpdateScore();
        OnTriggerEnter2D(collision);

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            if (Application.loadedLevelName == "Fiesta!")
            {
                Vector3 coinPosition = new Vector3(5f + collision.gameObject.transform.position.x, UnityEngine.Random.Range(0.5f, 1.5f), 0);

                Instantiate(coin, coinPosition, Quaternion.identity);
            }
            score += 1;
            audioSource.PlayOneShot(coinSound);
            Destroy(collision.gameObject);
        }
    }
    public void UpdateScore()
    {
        text.text = "Score: " + score;
    }


}