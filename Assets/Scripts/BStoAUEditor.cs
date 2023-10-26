using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

[CustomEditor((typeof(BStoAU)))]
public class BStoAUEditor : Editor
{
    private bool _foldout1;
    private bool _foldout2;
    public override void OnInspectorGUI()
    {
        BStoAU bStoAU = (BStoAU)target;
        DrawDefaultInspector();
        _foldout1 = EditorGUILayout.Foldout(_foldout1, "Action Units");
        if (_foldout1)
        {
            bStoAU.AU1 = EditorGUILayout.Slider("AU1",bStoAU.AU1, .0f, 100f);
            bStoAU.AU2 = EditorGUILayout.Slider("AU2",bStoAU.AU2, .0f, 100f);
            bStoAU.AU4 = EditorGUILayout.Slider("AU4",bStoAU.AU4, .0f, 100f);
            bStoAU.AU5 = EditorGUILayout.Slider("AU5",bStoAU.AU5, .0f, 100f);
            bStoAU.AU6 = EditorGUILayout.Slider("AU6",bStoAU.AU6, .0f, 100f);
            bStoAU.AU7 = EditorGUILayout.Slider("AU7",bStoAU.AU7, .0f, 100f);
            bStoAU.AU9 = EditorGUILayout.Slider("AU9",bStoAU.AU9, .0f, 100f);
            bStoAU.AU10 = EditorGUILayout.Slider("AU10",bStoAU.AU10, .0f, 100f);
            bStoAU.AU12 = EditorGUILayout.Slider("AU12",bStoAU.AU12, .0f, 100f);
            bStoAU.AU14 = EditorGUILayout.Slider("AU14",bStoAU.AU14, .0f, 100f);
            bStoAU.AU15 = EditorGUILayout.Slider("AU15",bStoAU.AU15, .0f, 100f);
            bStoAU.AU16 = EditorGUILayout.Slider("AU16",bStoAU.AU16, .0f, 100f);
            bStoAU.AU17 = EditorGUILayout.Slider("AU17",bStoAU.AU17, .0f, 100f);
            bStoAU.AU18 = EditorGUILayout.Slider("AU18",bStoAU.AU18, .0f, 100f);
            bStoAU.AU20 = EditorGUILayout.Slider("AU20",bStoAU.AU20, .0f, 100f);
            bStoAU.AU22 = EditorGUILayout.Slider("AU22",bStoAU.AU22, .0f, 100f);
            bStoAU.AU24 = EditorGUILayout.Slider("AU24",bStoAU.AU24,.0f, 100f);
            bStoAU.AU26 = EditorGUILayout.Slider("AU26",bStoAU.AU26, .0f, 100f);
            bStoAU.AU28 = EditorGUILayout.Slider("AU28",bStoAU.AU28, .0f, 100f);
            bStoAU.AU45 = EditorGUILayout.Slider("AU45",bStoAU.AU45, .0f, 100f);
            bStoAU.AU65 = EditorGUILayout.Slider("AU65",bStoAU.AU65, .0f, 100f);
            bStoAU.AU66 = EditorGUILayout.Slider("AU66",bStoAU.AU66, .0f, 100f);
            bStoAU.AD29 = EditorGUILayout.Slider("AD29",bStoAU.AD29, .0f, 100f);
            bStoAU.AD30 = EditorGUILayout.Slider("AD30",bStoAU.AD30, .0f, 100f);
            bStoAU.AD34 = EditorGUILayout.Slider("AD34",bStoAU.AD34, .0f, 100f);
            bStoAU.M63 = EditorGUILayout.Slider("M63",bStoAU.M63, .0f, 100f);
            bStoAU.M64 = EditorGUILayout.Slider("M64",bStoAU.M64, .0f, 100f);
        }
        _foldout2 = EditorGUILayout.Foldout(_foldout2, "Facial expressions");
        if (_foldout2)
        {
            if (GUILayout.Button("anger"))
            {
                bStoAU.AU1 = 0;
                bStoAU.AU2 = 0;
                bStoAU.AU4 = 100f;
                bStoAU.AU5 = 60f;
                bStoAU.AU6 = 0;
                bStoAU.AU7 = 0;
                bStoAU.AU9 = 0;
                bStoAU.AU10 = 0;
                bStoAU.AU12 = 0;
                bStoAU.AU14 = 0;
                bStoAU.AU15 = 60f;
                bStoAU.AU17 = 60f;
                bStoAU.AU20 = 0;
                // bStoAU.AU23 = 0;
                // bStoAU.AU25 = 0;
                bStoAU.AU26 = 0;
                bStoAU.AU28 = 0;
                bStoAU.AU45 = 0;
                bStoAU.Anger();
            }
            if (GUILayout.Button("contempt"))
            {
                bStoAU.AU1 = 0;
                bStoAU.AU2 = 0;
                bStoAU.AU4 = 0;
                bStoAU.AU5 = 0;
                bStoAU.AU6 = 0;
                bStoAU.AU7 = 0;
                bStoAU.AU9 = 0;
                bStoAU.AU10 = 0;
                bStoAU.AU12 = 0;
                bStoAU.AU14 = 0;
                bStoAU.AU15 = 0;
                bStoAU.AU17 = 0;
                bStoAU.AU20 = 0;
                // bStoAU.AU23 = 100f;
                // bStoAU.AU25 = 0;
                bStoAU.AU26 = 0;
                bStoAU.AU28 = 0;
                bStoAU.AU45 = 0;
                bStoAU.Contempt();
            }
            if (GUILayout.Button("disgust"))
            {
                bStoAU.AU1 = 0;
                bStoAU.AU2 = 0;
                bStoAU.AU4 = 100f;
                bStoAU.AU5 = 0;
                bStoAU.AU6 = 0;
                bStoAU.AU7 = 0;
                bStoAU.AU9 = 40f;
                bStoAU.AU10 = 100f;
                bStoAU.AU12 = 0;
                bStoAU.AU14 = 0;
                bStoAU.AU15 = 100f;
                bStoAU.AU17 = 100f;
                bStoAU.AU20 = 0;
                // bStoAU.AU23 = 0;
                // bStoAU.AU25 = 0;
                bStoAU.AU26 = 0;
                bStoAU.AU28 = 0;
                bStoAU.AU45 = 0;
                bStoAU.Disgust();
            }
            if (GUILayout.Button("fear"))
            {
                bStoAU.AU1 = 60f;
                bStoAU.AU2 = 0;
                bStoAU.AU4 = 60f;
                bStoAU.AU5 = 0;
                bStoAU.AU6 = 0;
                bStoAU.AU7 = 60f;
                bStoAU.AU9 = 0;
                bStoAU.AU10 = 0;
                bStoAU.AU12 = 0;
                bStoAU.AU14 = 0;
                bStoAU.AU15 = 0;
                bStoAU.AU17 = 0;
                bStoAU.AU20 = 60f;
                // bStoAU.AU23 = 60f;
                // bStoAU.AU25 = 60f;
                bStoAU.AU26 = 60f;
                bStoAU.AU28 = 0;
                bStoAU.AU45 = 0;
                bStoAU.Fear();
            }
            if (GUILayout.Button("happiness"))
            {
                bStoAU.AU1 = 0;
                bStoAU.AU2 = 0;
                bStoAU.AU4 = 0;
                bStoAU.AU5 = 0;
                bStoAU.AU6 = 100f;
                bStoAU.AU7 = 0;
                bStoAU.AU9 = 0;
                bStoAU.AU10 = 0;
                bStoAU.AU12 = 60f;
                bStoAU.AU14 = 0;
                bStoAU.AU15 = 0;
                bStoAU.AU17 = 0;
                bStoAU.AU20 = 0;
                // bStoAU.AU23 = 0;
                // bStoAU.AU25 = 100f;
                bStoAU.AU26 = 0;
                bStoAU.AU28 = 0;
                bStoAU.AU45 = 0;
                bStoAU.Happiness();
            }
            if (GUILayout.Button("neutral"))
            {
                bStoAU.AU1 = 0;
                bStoAU.AU2 = 0;
                bStoAU.AU4 = 0;
                bStoAU.AU5 = 0;
                bStoAU.AU6 = 0;
                bStoAU.AU7 = 0;
                bStoAU.AU9 = 0;
                bStoAU.AU10 = 0;
                bStoAU.AU12 = 0;
                bStoAU.AU14 = 0;
                bStoAU.AU15 = 0;
                bStoAU.AU17 = 0;
                bStoAU.AU20 = 0;
                // bStoAU.AU23 = 0;
                // bStoAU.AU25 = 0;
                bStoAU.AU26 = 0;
                bStoAU.AU28 = 0;
                bStoAU.AU45 = 0;
                bStoAU.Neutral();
            }
            if (GUILayout.Button("sadness"))
            {
                bStoAU.AU1 = 100f;
                bStoAU.AU2 = 0;
                bStoAU.AU4 = 100f;
                bStoAU.AU5 = 0;
                bStoAU.AU6 = 0;
                bStoAU.AU7 = 0;
                bStoAU.AU9 = 0;
                bStoAU.AU10 = 0;
                bStoAU.AU12 = 0;
                bStoAU.AU14 = 0;
                bStoAU.AU15 = 100f;
                bStoAU.AU17 = 60f;
                bStoAU.AU20 = 0;
                // bStoAU.AU23 = 0;
                // bStoAU.AU25 = 0;
                bStoAU.AU26 = 0;
                bStoAU.AU28 = 0;
                bStoAU.AU45 = 0;
                bStoAU.Sadness();
            }
            if (GUILayout.Button("shock"))
            {
                bStoAU.AU1 = 60f;
                bStoAU.AU2 = 60f;
                bStoAU.AU4 = 40f;
                bStoAU.AU5 = 80f;
                bStoAU.AU6 = 0;
                bStoAU.AU7 = 40f;
                bStoAU.AU9 = 0;
                bStoAU.AU10 = 0;
                bStoAU.AU12 = 0;
                bStoAU.AU14 = 0;
                bStoAU.AU15 = 0;
                bStoAU.AU17 = 0;
                bStoAU.AU20 = 40f;
                // bStoAU.AU23 = 0;
                // bStoAU.AU25 = 0;
                bStoAU.AU26 = 40f;
                bStoAU.AU28 = 0;
                bStoAU.AU45 = 0;
                bStoAU.Shock();
            }
            if (GUILayout.Button("surprise"))
            {
                bStoAU.AU1 = 60f;
                bStoAU.AU2 = 60f;
                bStoAU.AU4 = 0;
                bStoAU.AU5 = 60f;
                bStoAU.AU6 = 0;
                bStoAU.AU7 = 0;
                bStoAU.AU9 = 0;
                bStoAU.AU10 = 0;
                bStoAU.AU12 = 0;
                bStoAU.AU14 = 0;
                bStoAU.AU15 = 0;
                bStoAU.AU17 = 0;
                bStoAU.AU20 = 0;
                // bStoAU.AU23 = 0;
                // bStoAU.AU25 = 0;
                bStoAU.AU26 = 60f;
                bStoAU.AU28 = 0;
                bStoAU.AU45 = 0;
                bStoAU.Surprise();
            }
        }
    }
}
