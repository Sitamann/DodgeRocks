using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
public class BallSpawner : MonoBehaviour
{
    public static BallSpawner BS;
    public GameObject Ballfab;
    public int xpos;
    public int zpos;
    public int enemyCount1;
    public float x = 3f;
    public float y;
    public float delai = 4;
    bool GO = false;

    void Start()
    {
        BS = this;
        delai = x;
    }

    private void Spawnball()
    {
        xpos = Random.Range(-7, 11);
        zpos = Random.Range(-10, 8);
        Instantiate(Ballfab, new Vector3(xpos, 175, zpos), Quaternion.identity);
        if (x > 1)
            x = x - y;
        enemyCount1 += 1;

    }
    private void Update()
    {
        if (delai > 0)
        {
            delai -= Time.deltaTime;
            if (delai <= 0)
            {
                Spawnball();
                delai = x;
            }
        }
     
    }
    

    IEnumerator BallDrop()
    {
       
            xpos = Random.Range(-7, 11);
            zpos = Random.Range(-10, 8);
            Instantiate(Ballfab, new Vector3(xpos, 175, zpos), Quaternion.identity);
            if (x > 1)
                x = x - y;
            enemyCount1 += 1;
            yield return new WaitForSeconds(x);
        

    }


}  
