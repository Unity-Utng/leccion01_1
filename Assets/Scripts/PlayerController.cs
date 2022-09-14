using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad =20;
    public float velGiro = 20; 
    private float avanza;
    private float gira;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        avanza = Input.GetAxis("Vertical");
        gira = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward*Time.deltaTime*velocidad*avanza);
        transform.Rotate(Vector3.up, Time.deltaTime*velGiro*gira);
    }
}
