using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

namespace group1
{
    [CustomEditor(typeof(PathFindingAgent))]
    public class PathFindingAgentEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            PathFindingAgent pathFindingAgent = (PathFindingAgent)target;

            if (GUILayout.Button("Go To Target"))
            {
                pathFindingAgent.GoToTarget();
            }
        }
    }
}


