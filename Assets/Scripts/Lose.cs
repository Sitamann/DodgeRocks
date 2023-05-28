using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Lose : MonoBehaviour
{

    public Rigidbody rb;
    bool GO = false;
    public int delai = 5;
    void Start()
    {
        
    }

    public void FixedUpdate()
    {
        if (rb.position.y < 150f)
        {
            EndGame();
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);


    }


    public void EndGame()
    {
    if (GO == false)
        {
             GO = true;
            Movement.inst.canwalk = false;

            Movement.inst.anim.SetBool("die", true);
             Invoke("restart", delai);
        }

    }
}