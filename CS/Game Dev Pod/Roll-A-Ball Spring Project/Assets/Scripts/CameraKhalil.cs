using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraKhalil : MonoBehaviour
{

    public GameObject target;

    public Vector3 posOffset;

    // Start is called before the first frame update
    void Start()
    {
        posOffset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if  (target !=null)
        {
            Vector3 newPos = target.transform.position + posOffset; 
            transform.position = newPos;
        }
    }
    
}
