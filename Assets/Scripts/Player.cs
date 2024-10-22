using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float moveSpeed = 5f;
    void Start()
    {
        
    }

    
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); 

        Vector3 movement = new Vector3(moveHorizontal, 0,0); 
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
