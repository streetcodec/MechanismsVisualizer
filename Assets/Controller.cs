using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Controller : MonoBehaviour
{
    public Rigidbody R;
    public Slider S;

    private void FixedUpdate()
    {
        var Point = this.transform.TransformPoint(new Vector3(.45f,0,0));
        var Force = this.transform.TransformVector(new Vector3(0,100,0));
        R.AddForceAtPosition(R.mass * Force * S.value , Point);
    }
}
