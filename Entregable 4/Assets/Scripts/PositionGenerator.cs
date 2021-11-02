using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGenerator : MonoBehaviour
{
    private Vector3 Coordenadas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
           Coordenadas = RandomPosition();
           transform.position = Coordenadas;

        }
    }
    public Vector3 RandomPosition()
    {
       return new Vector3(Random.Range(0, 8), Random.Range(0, 8), Random.Range(0, 8));
    } 
}
