using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finnish : MonoBehaviour
{   
    [SerializeField]
    private int points;
    void Start()
    {
        points = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        points++;
    }
}
