using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class CanonPlayer : MonoBehaviour
{

    GameObject canon;
    float speed = 0.08f;

    void Start()
    {
        canon = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            canon.transform.position += new Vector3(speed, 0, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
            canon.transform.position += new Vector3(-speed, 0, 0);
    }
}
