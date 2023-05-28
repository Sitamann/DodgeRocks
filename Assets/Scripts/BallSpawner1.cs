using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BallSpawner1 : MonoBehaviour
{
    public GameObject Ballfab;
    public int xpos;
    public int zpos;
    public int enemyCount;
    public float x = 3f;
    public float y;
    public float delai;
    bool GO = false;
    

    void Start()
    {
        
        delai = x;
    }

    private void Spawnball()
    {
        if (BallSpawner.BS.enemyCount1 >5)
        {
            xpos = Random.Range(-7, 11);
            zpos = Random.Range(-10, 8);
            Instantiate(Ballfab, new Vector3(xpos, 175, zpos), Quaternion.identity);
            if (x > 1)
                x = x - y;
            enemyCount += 1;
        }
    }
    private void Update()
    {
        if (delai>0)
        {
            delai-= Time.deltaTime;
            if(delai<=0)
            {
                Spawnball();
                delai = x;
            }
        }
          
    }
    IEnumerator BallDrop()
    {
        while (enemyCount > 100)
        {
            xpos = Random.Range(-7, 11);
            zpos = Random.Range(-10, 8);
            Instantiate(Ballfab, new Vector3(xpos, 175, zpos), Quaternion.identity);
            if (x > 1)
                x = x - y;
           
            yield return new WaitForSeconds(x);
        }

    }


}  
