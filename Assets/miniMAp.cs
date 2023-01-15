using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniMAp : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;

     void LateUpdate()

    {
        Vector3 newposition = player.position;
        newposition.y = transform.position.y;
        transform.position = newposition;

        transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);

    }
}
