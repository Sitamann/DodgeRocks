using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float x = 120;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision Collinfo)
    {
        if (gameObject.tag == "Obstacle")
            {

            if (Collinfo.collider.tag == "Ground")
        {
                gameObject.tag = "Ground";
                Debug.Log("Done");
            }
            }
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < x)
            Destroy(gameObject);
    }
    
}
