using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    public Transform SadIdle;

    void LateUpdate()
    {
        Vector3 newPosition = SadIdle.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        transform.rotation = Quaternion.Euler(90f, SadIdle.eulerAngles.y, 0f);
    }

}
