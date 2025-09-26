using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound) 
        {
            Debug.Log("GAME OVER! NOOB HA-HA-HA");
            Destroy(gameObject);
        }
    }
}
