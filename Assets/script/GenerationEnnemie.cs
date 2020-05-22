using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationEnnemie : MonoBehaviour
{
    public GameObject ennemie;

    public void CreateEnnemie(float colone, float  ligne)
    {
        for (int c = 0; c < colone; c++)
        {
            for (int l = 0; l < ligne; l++)
            {
                Instantiate(ennemie, new Vector3(c, l, 0), Quaternion.identity, gameObject.transform);
            }
        }
    }
}
