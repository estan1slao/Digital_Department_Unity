using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMod : MonoBehaviour
{
    private Rigidbody _rb;
    private bool _activeBonus = false;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !_activeBonus)
        {
            _activeBonus = true;

            _rb.isKinematic = false;
            _rb.mass *= 10;
            _rb.position = _rb.position + new Vector3(0, 3, 0);

        }

        else if (Input.GetKeyDown(KeyCode.Space) && _activeBonus)
        {
            _activeBonus = false;

            _rb.isKinematic = true;
        }

    }
}
