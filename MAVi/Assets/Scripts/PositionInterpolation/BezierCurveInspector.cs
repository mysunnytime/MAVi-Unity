﻿/*using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SetPositions))]
public class BezierCurveInspector : Editor
{

    private SetPositions curve;
    private Transform handleTransform;
    private Quaternion handleRotation;
    private const float directionScale = 0.5f;
    private const int lineSteps = 10;
    private void OnSceneGUI()
    {
        curve = target as SetPositions;
        handleTransform = curve.transform;
        handleRotation = Tools.pivotRotation == PivotRotation.Local ?
            handleTransform.rotation : Quaternion.identity;

        Vector3 p0 = ShowPoint(0);
        Vector3 p1 = ShowPoint(1);
        Vector3 p2 = ShowPoint(2);
        Vector3 p3 = ShowPoint(3);
        Vector3 p4 = ShowPoint(4);

        Handles.color = Color.white;
        Handles.DrawLine(p0, p1);
        Handles.DrawLine(p1, p2);
        Handles.DrawLine(p2, p3);
        Handles.DrawLine(p3, p4);

        ShowDirections();
        Handles.DrawBezier(p0, p4, p1, p3, Color.white, null, 2f);
        Vector3 lineStart = curve.GetPoint(0f);
        for (int i = 1; i <= lineSteps; i++)
        {
            Vector3 lineEnd = curve.GetPoint(i / (float)lineSteps);
            Handles.DrawLine(lineStart, lineEnd);
            lineStart = lineEnd;
        }


    }

    public void ShowDirections()
    {
        Handles.color = Color.green;
        Vector3 point = curve.GetPoint(0f);
        Handles.DrawLine(point, point + curve.GetDirection(0f) * directionScale);
        for (int i = 1; i <= lineSteps; i++)
        {
            point = curve.GetPoint(i / (float)lineSteps);
            Handles.DrawLine(point, point + curve.GetDirection(i / (float)lineSteps) * directionScale);
        }
    }
    private Vector3 ShowPoint(int index)
    {
        Vector3 point = handleTransform.TransformPoint(curve.points[index]);
        EditorGUI.BeginChangeCheck();
        point = Handles.DoPositionHandle(point, handleRotation);
        if (EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(curve, "Move Point");
            EditorUtility.SetDirty(curve);
            curve.points[index] = handleTransform.InverseTransformPoint(point);
        }
        return point;
    }
}*/
