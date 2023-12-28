using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GuardSnowmanManager))]
public class GuardEditor : Editor
{
    private void OnSceneGUI()
    {
        GuardSnowmanManager _guard = (GuardSnowmanManager)target;

        Color c = Color.green;

        Handles.color = new Color(c.r, c.g, c.b, 0.2f);
        Handles.DrawSolidArc(
            _guard.transform.position,
            _guard.transform.up,
            Quaternion.AngleAxis(-_guard.fovAngle / 2f, _guard.transform.up) * _guard.transform.forward,
            _guard.fovAngle,
            _guard.fov);

        Handles.color = c;
        _guard.fov = Handles.ScaleValueHandle(
            _guard.fov,
            _guard.transform.position + _guard.transform.forward * _guard.fov,
            _guard.transform.rotation,
            3,
            Handles.SphereHandleCap,
            1);
    }   
}
