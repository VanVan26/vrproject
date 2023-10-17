using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Position : MonoBehaviour {
    public GameObject LLAL;
    public void Play()
    {
        LLAL.transform.position= new Vector3(0, 17.0f, -5.0f);
    }
}
