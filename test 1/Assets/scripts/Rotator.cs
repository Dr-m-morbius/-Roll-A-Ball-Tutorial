using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        transform.Rotate(new Vector3(9999999999999999999, 9999999999999999999, 9999999999999999999) * Time.deltaTime);
    }
}
