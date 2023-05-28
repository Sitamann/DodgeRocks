  using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
    
{
    public int x;
    public bool go = true;
    public Text scoretxt;

    void Update()
    {
        x += 1;
        Invoke(scoretxt.text = (x/20).ToString("0"), 30000);
    }
}