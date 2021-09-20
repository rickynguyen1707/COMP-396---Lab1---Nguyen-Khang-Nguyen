using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestVectorsAndMatrices : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 v1 = new Vector3(1.5f, 2.5f, 3.5f);
        Vector3 v2 = new Vector3(1.0f, -3.5f, 1.5f);
        float k = 0.75f;

        Debug.Log("v1 = " + v1);
        Debug.Log("v2 = " + v2);
        Debug.Log("v1 + v2 = " + (v1 + v2));
        Debug.Log("v1 - v2 = " + (v1 - v2));
        Debug.Log("k * v1 = " + (k*v1));
        Debug.Log("k * v2 = " + (k * v2));

        float v1Dotv2 = Vector3.Dot(v1, v2);
        Debug.Log("v1, v2 dot product = " + v1Dotv2);

        Vector3 v1Crossv2 = Vector3.Cross(v1, v2);
        Debug.Log("v1 cross v2 = " + v1Crossv2);

        float v1Mag = Vector3.Magnitude(v1);
        Debug.Log("Magnitude of v1 = " + v1Mag);

        float v2Mag = Vector3.Magnitude(v2);
        Debug.Log("Magnitude of v2 = " + v2Mag);

        float v1v2Angle = Vector3.Angle(v1, v2);
        Debug.Log("Angle between v1, v2 = " + v1v2Angle);

        float cosv1v2Angle = v1Dotv2 / (v1Mag * v2Mag);
        Debug.Log(cosv1v2Angle);
        float v1v2AngleWithMathf = Mathf.Acos(cosv1v2Angle);
        Debug.Log("Angle (in radian) between v1, v2 with Mathf" + v1v2AngleWithMathf);
        float v1v2AngleWithMathfInDegree = v1v2AngleWithMathf * 180 / Mathf.PI;
        Debug.Log("Angle (in degree) between v1, v2 with Mathf" + v1v2AngleWithMathfInDegree);
        Debug.Assert(v1v2Angle == v1v2AngleWithMathfInDegree);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
