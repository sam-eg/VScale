using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverScript : MonoBehaviour
{
    ConstantForce force;
    public float elaspedTime = 0;
    bool started = false;

    // Start is called before the first frame update
    void Start()
    {
        force = GetComponent<ConstantForce>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!started)
        {
            elaspedTime = elaspedTime + Time.deltaTime;
            if (elaspedTime > 5)
            {
                force.enabled = true;
                started = true;
            }
        }
    }
}
