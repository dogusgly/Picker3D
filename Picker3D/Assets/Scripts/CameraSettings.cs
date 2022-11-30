using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSettings : MonoBehaviour
{
   
    [SerializeField] private GameObject collector;
    [SerializeField] private float camOffset;


    private void LateUpdate()
    {
        transform.position = new Vector3(
            collector.transform.position.x + camOffset, transform.position.y, transform.position.z);
    }

}
