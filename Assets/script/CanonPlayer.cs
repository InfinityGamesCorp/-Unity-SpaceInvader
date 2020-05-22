using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class CanonPlayer : MonoBehaviour
{
    //Player
    GameObject canon;
    float speed = 0.08f;

    //Shooter
    public GameObject gm;

    void Start()
    {
        canon = gameObject;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            canon.transform.position += new Vector3(speed, 0, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
            canon.transform.position += new Vector3(-speed, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ProjectileShoot(canon.transform.position + new Vector3(0,0.4f,0));
        }

        if (canon.transform.position.x > 8.5f)
            canon.transform.position = new Vector3(8.5f, -4f, 0f);
        if (canon.transform.position.x < -8.5f)
            canon.transform.position = new Vector3(-8.5f, -4f, 0f);
    }

    public void ProjectileShoot(Vector3 position)
    {
        Instantiate(gm, position, Quaternion.identity);
    }
}
