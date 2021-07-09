using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddleL : MonoBehaviour
{
    
    [SerializeField]
    private float PlayerSpeed = 5.0f;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + (Input.GetAxis("Vertical") * PlayerSpeed * Time.deltaTime), transform.position.z);
    }
}
