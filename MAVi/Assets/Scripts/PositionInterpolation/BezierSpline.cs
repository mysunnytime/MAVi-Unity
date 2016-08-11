using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BezierSpline : MonoBehaviour
{

    private Vector3 Position1;
    private Quaternion Rotation1;
    private Vector3 Position2;
    private Quaternion Rotation2;
    private Vector3 Position3;
    private Quaternion Rotation3;
    private Vector3 Position4;
    private Quaternion Rotation4;
    private Vector3 Position5;
    private Quaternion Rotation5;



    public void Save1Function()
    {
        Position1 = Camera.main.gameObject.transform.position;
        Rotation1 = Camera.main.gameObject.transform.rotation;

    }

    public void Save2Function()
    {
        Position2 = Camera.main.gameObject.transform.position;
        Rotation2 = Camera.main.gameObject.transform.rotation;

    }

    public void Save3Function()
    {
        Position3 = Camera.main.gameObject.transform.position;
        Rotation3 = Camera.main.gameObject.transform.rotation;
    }

    public void Save4Function()
    {
        Position4 = Camera.main.gameObject.transform.position;
        Rotation4 = Camera.main.gameObject.transform.rotation;
    }

    public void Save5Function()
    {
        Position5 = Camera.main.gameObject.transform.position;
        Rotation5 = Camera.main.gameObject.transform.rotation;

    }
    public void Preset1Fun()
    {
        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, Position1, 2.0f);
        Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, Rotation1, 2.0f);
    }

    public void Preset2Fun()
    {
        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, Position2, 2.0f);
        Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, Rotation2, 2.0f);
    }

    public void Preset3Fun()
    {
        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, Position3, 2.0f);
        Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, Rotation3, 2.0f);
    }
    public void Preset4Fun()
    {
        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, Position4, 2.0f);
        Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, Rotation4, 2.0f);
    }

    public void Preset5Fun()
    {
        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, Position5, 2.0f);
        Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, Rotation5, 2.0f);
    }

    public static class Bezier
    {

        public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, float t)
        {
            t = Mathf.Clamp01(t);
            float oneMinusT = 1f - t;
            return
                oneMinusT * oneMinusT * oneMinusT * oneMinusT * p0 +
                4f * oneMinusT * oneMinusT * oneMinusT * t * p1 +
                6f * oneMinusT * oneMinusT * t * t * p2 +
                4f * oneMinusT * t * t * t * p3 +
                t * t * t * t * p4;
        }
        public static Vector3 GetFirstDerivative(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, float t)
        {
            float oneMinusT = 1f - t;
            return
                4 * t * t * t * (p4 - p3) +
                12 * oneMinusT * t * t * (p3 - p2) +
                12 * oneMinusT * oneMinusT * t * (p2 - p1) +
                4 * oneMinusT * oneMinusT * oneMinusT * (p1 - p0);

        }
    }
    public Vector3 GetPoint(float t)
    {
        return Bezier.GetPoint(points[0], points[1], points[2], points[3], points[4], t);
    }
    public Vector3[] points;
    public void Reset()
    {
        points = new Vector3[] { Position1, Position2, Position3, Position4, Position5 };

    }

    public Vector3 GetVelocity(float t)
    {
        return transform.TransformPoint(Bezier.GetFirstDerivative(points[0], points[1], points[2], points[3], points[4], t)) -
            transform.position;
    }
    public Vector3 GetDirection(float t)
    {
        return GetVelocity(t).normalized;
    }

}




