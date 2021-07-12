using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{   

    private bool isUp = true;
    private float UpDown = 1.0f;
    Vector3 vector = new Vector3();

    [SerializeField]
    private float BallSpeed = 5.5f;

    // Ball in the beginning of the round
    void Start()
    {
        
        // 0 is left, 1 is right
        int side = Random.Range(0,2);

        // Determines if ball goes up or down start of round
        if(Random.Range(0,2) == 1){
            isUp = false;
            UpDown = -1.0f;
        }

        /// <summary>
        /// The screen is effectively cut into three quadrants for the ball to travel, with certain angles unattainable
        /// because that would make the ball go too vertical.
        /// </summary>
        if(side == 0 && isUp){
            vector = Quaternion.AngleAxis(Random.Range(110.0f, 180.0f), Vector3.forward) * Vector3.right;
            GetComponent<Rigidbody2D>().velocity = vector * BallSpeed;
        }

        else if(side == 0 && !isUp){
            vector = Quaternion.AngleAxis(Random.Range(180.0f, 250.0f), Vector3.forward) * Vector3.right;
            GetComponent<Rigidbody2D>().velocity = vector * BallSpeed;
        }

        else if(side == 1 && isUp){
            vector = Quaternion.AngleAxis(Random.Range(0.0f, 70.0f), Vector3.forward) * Vector3.right;
            GetComponent<Rigidbody2D>().velocity = vector * BallSpeed;
        }

        else{
            vector = Quaternion.AngleAxis(Random.Range(290.0f, 360.0f), Vector3.forward) * Vector3.right;
            GetComponent<Rigidbody2D>().velocity = vector * BallSpeed;
        }

    }

    void WallBounce(Collision2D coll){
        //y = -y
        if(coll.collider.tag == "Bumper"){
            vector.y = -vector.y;
        }
    }

    //x = -x when ball hits paddle
}