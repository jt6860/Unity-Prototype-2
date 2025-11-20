using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float bottomBound = -14;
    public float topBound = 32;
    public float leftBound = -26;

    public int missesAllowed = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < bottomBound | transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.z > topBound)
        {
            DestroyTracker.IncrementDestroyedCount();
            int animalMisses = DestroyTracker.GetDestroyedCount();
            if ((missesAllowed - animalMisses) > 0) {
                missesAllowed = missesAllowed - animalMisses;
                Debug.Log("Animal Misses Left: " + missesAllowed);
            }
            else if ((missesAllowed - animalMisses) == 0)
            {
                Debug.Log("No Animal Misses Left! Game Over!");
            }                
            
            Destroy(gameObject);
        }
    }
}
