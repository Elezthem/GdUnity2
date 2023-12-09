using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const float Speed = 8;

    void Update()
    {
        transform.Translate(new Vector2(Speed * Time.deltaTime, 0));
    }
}
