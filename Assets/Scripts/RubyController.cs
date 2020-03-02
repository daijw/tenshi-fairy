using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //Float stores the results
        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        //Ruby canmove horizontal = 3 fps
        position.y = position.y + 3.0f * vertical * Time.deltaTime;
        //Ruby canmove vertical = 3 fps
        transform.position = position;
    }
}
