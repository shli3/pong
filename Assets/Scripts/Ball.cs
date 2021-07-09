using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{   

    private int side;
    private bool isUp = true;
    private float UpDown = 1.0f;

    [SerializeField]
    private float BallSpeed = 5.5f;

    // Start is called before the first frame update
    void Start()
    {
        
        side = Random.Range(0,2);
        
        //determines if ball goes up or down start of round
        if(Random.Range(0,2) == 1){
            isUp = false;
            UpDown = -1.0f;
        }

    }

    void Update()
    {
        
        if(side == 0){
            //Go left
            transform.position = new Vector3(transform.position.x + (-1  * Time.deltaTime), transform.position.y + (UpDown * Random.Range(0f, 1.0f) * BallSpeed * Time.deltaTime), transform.position.z);
        }

        else{
            //Go right
            transform.position = new Vector3(transform.position.x + Time.deltaTime, transform.position.y + (UpDown * Random.Range(0f, 1.0f) * BallSpeed * Time.deltaTime), transform.position.z);
        }

        Debug.Log(transform.position.x);
        
    }


}
