// Lárus Ármann Kjartansson - 19/mars/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour// býr til klasa
{
    private float speed = 5.0f; //setur hraðan
    private float turnSpeed = 25.0f; // segjir hversu hratt á að snúa bílnum þegar er beygt
    private float horizontalInput; // stjórnar vinstri og hægri örvartökkum
    private float forwardInput; // stjórnar áfram og aftur örvartökkum
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");// skrifar inn í horizontalInput
        forwardInput = Input.GetAxis("Vertical");// skrifar inn í forwardInput

        // Move the vehicle based on input params
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);// keyrir áfram
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput); // leyfir bílnum að beygja á meðan er keyrt áfram, annars hefði hann bara farið beint til hliðar og bíllin ekkert snúist í leiðinni
    }
}
