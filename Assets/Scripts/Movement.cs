using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (new Vector3(Input.GetAxis("Horizontal") / 1000, 0, Input.GetAxis("Vertical") / 1000));
    }
}
