using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    public Vector3 rotateObject = new Vector3(40, 50, 30);

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateObject * Time.deltaTime);
    }
}
