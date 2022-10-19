using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNetwork : MonoBehaviour
{
    float moveVelocity = 6;

    void Update()
    {

        float _moveVertical = Input.GetAxis("Vertical") * moveVelocity * Time.deltaTime;
        //float _moveHorizontal = Input.GetAxis("Horizontal") * _velocity * Time.deltaTime;
        float _moveHorizontal = Input.GetAxis("Horizontal") * moveVelocity * Time.deltaTime;


        transform.Translate(_moveHorizontal, 0, _moveVertical);



    }
}
