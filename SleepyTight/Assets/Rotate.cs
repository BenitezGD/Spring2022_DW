using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    void Update()
    {

    }

    private void OnMouseDown()
    {
        float AngleRad = Mathf.Atan2(Input.mousePosition.y - transform.position.y, Input.mousePosition.x - transform.position.x);

        float AngleDeg = (180 / Mathf.PI) * AngleRad;
        this.transform.rotation = Quaternion.Euler(0, 0, AngleDeg);
    }
}
