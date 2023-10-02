using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snegovik : MonoBehaviour
{
    public GameObject Delete;

    public void Play()
    {

        Delete.SetActive(!Delete.activeSelf);

    }
}