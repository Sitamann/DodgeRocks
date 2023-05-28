
using UnityEngine;

public class obstaclee : MonoBehaviour
    

{
    public Rigidbody rb;
    void OnCollisionEnter(Collision Collinfo)
    {
        if (Collinfo.collider.tag == "Obstacle")
        {   
            FindObjectOfType<Lose>().EndGame(); //singleton
        }
        if (Collinfo.collider.tag == "Obstacle1")
        {
            FindObjectOfType<Lose>().EndGame(); //singleton
        }
    }
    
}
