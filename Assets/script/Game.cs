using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    public GenerationEnnemie generationEnnemie;
    float colones = 15;
    float lignes = 5;

    void Start()
    {
        generationEnnemie.CreateEnnemie(colones, lignes);
        generationEnnemie.transform.position = new Vector3(((colones / 2) * -1) + 0.5f, 0,0);
    }
}
