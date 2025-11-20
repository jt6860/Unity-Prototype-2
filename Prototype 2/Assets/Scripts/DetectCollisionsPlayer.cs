using UnityEngine;

public class DetectCollisionsPlayer : MonoBehaviour
{
    public int playerLives = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Projectile"))
        {
            if (CompareTag("Player") & playerLives > 0)
            {
                playerLives--;
            }

            if (CompareTag("Player") & playerLives > 0)
            {
                Debug.Log("Player Lives Left: " + playerLives);
                Destroy(other.gameObject);
            }
            else if (CompareTag("Player") & playerLives == 0)
            {
                Debug.Log("No Lives Left! Game Over!");
                Destroy(other.gameObject);
                Destroy(gameObject);
            }
            else if (!CompareTag("Player"))
            {
                Destroy(other.gameObject);
                Destroy(gameObject);
            }
        }
    }
}