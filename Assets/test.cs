using UnityEngine;
using System.Collections;

public class test : MonoBehaviour
{
    public GameObject myObject;


    void Start()
    {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }
}