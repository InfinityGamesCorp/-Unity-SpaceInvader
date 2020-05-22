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

    // Update is called once per frame
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
    }

    public void ProjectileShoot(Vector3 position)
    {
        Instantiate(gm, position, Quaternion.identity);
    }
    private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Mur_Droit")
            canon.transform.position = new Vector3(8.3f, -4, 0);
    }
}
