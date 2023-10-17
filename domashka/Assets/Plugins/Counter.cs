using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text text;
    public int s;
    void Start()
    {
        s = 100;
        text.text = "S= " + s.ToString();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        s--;
       text.text ="S= " + s.ToString();
    }
    
    

}

