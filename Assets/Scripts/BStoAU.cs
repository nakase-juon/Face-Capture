using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BStoAU : MonoBehaviour
{
    [SerializeField]private GameObject characterHead;
    [SerializeField]private SkinnedMeshRenderer skinnedMeshRenderer;
    
    private Mesh _skinnedMesh;
    private int _blendShapeCount;
    
    [HideInInspector]
    [Range(.0f, 100f)] public float AU1, AU2, AU4, AU5, AU6, AU7, 
        AU9, AU10, AU12, AU14, AU15, AU16, AU17, AU18, AU20, AU22, AU24, 
        AU26, AU28, AU45, AU65, AU66, AD29, AD30, AD34,
        M63, M64;

    // private int[] ARKitLabels = new int[46];

    #region ARKitLabels
    
    private int _browInnerUpIndex;
    private int _browOuterUpLeftIndex;
    private int _browOuterUpRightIndex;
    private int _browDownLeftIndex;
    private int _browDownRightIndex;
    private int _eyeWideLeftIndex;
    private int _eyeWideRightIndex;
    private int _cheekSquintLeftIndex;
    private int _cheekSquintRightIndex;
    private int _eyeSquintLeftIndex;
    private int _eyeSquintRightIndex;
    private int _eyeBlinkLeftIndex;
    private int _eyeBlinkRightIndex;
    private int _eyeLookUpLeftIndex;
    private int _eyeLookUpRightIndex;
    private int _eyeLookDownLeftIndex;
    private int _eyeLookDownRightIndex;
    private int _eyeLookInLeftIndex;
    private int _eyeLookInRightIndex;
    private int _eyeLookOutLeftIndex;
    private int _eyeLookOutRightIndex;
    private int _noseSneerLeftIndex;
    private int _noseSneerRightIndex;
    private int _mouthUpperUpLeftIndex;
    private int _mouthUpperUpRightIndex;
    private int _mouthSmileLeftIndex;
    private int _mouthSmileRightIndex;
    private int _mouthLeftIndex;
    private int _mouthRightIndex;
    private int _mouthDimpleLeftIndex;
    private int _mouthDimpleRightIndex;
    private int _mouthFrownLeftIndex;
    private int _mouthFrownRightIndex;
    private int _mouthLowerDownLeftIndex;
    private int _mouthLowerDownRightIndex;
    private int _mouthShrugUpperIndex;
    private int _mouthShrugLowerIndex;
    private int _cheekPuffIndex;
    private int _mouthPuckerIndex;
    private int _mouthStretchLeftIndex;
    private int _mouthStretchRightIndex;
    private int _mouthFunnelIndex;
    private int _mouthPressLeftIndex;
    private int _mouthPressRightIndex;
    private int _mouthCloseIndex;
    private int _mouthRollUpperIndex;
    private int _mouthRollLowerIndex;
    private int _jawOpenIndex;
    private int _jawLeftIndex;
    private int _jawRightIndex;
    private int _jawForwardIndex;
    
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        skinnedMeshRenderer = characterHead.GetComponent<SkinnedMeshRenderer>();
        _skinnedMesh = characterHead.GetComponent<SkinnedMeshRenderer>().sharedMesh;
        _blendShapeCount = _skinnedMesh.blendShapeCount;

        #region searchIndex

        for (int i = 0; i < _blendShapeCount; i++)
        {
            if (_skinnedMesh.GetBlendShapeName(i) == "browInnerUp")
                _browInnerUpIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "browOuterUpLeft")
                _browOuterUpLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "browOuterUpRight")
                _browOuterUpRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "browDownLeft")
                _browDownLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "browDownRight")
                _browDownRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "eyeWideLeft")
                _eyeWideLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "eyeWideRight")
                _eyeWideRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "cheekSquintLeft")
                _cheekSquintLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "cheekSquintRight")
                _cheekSquintRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "eyeSquintLeft")
                _eyeSquintLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "eyeSquintRight")
                _eyeSquintRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "eyeBlinkLeft")
                _eyeBlinkLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "eyeBlinkRight")
                _eyeBlinkRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "eyeLookUpLeft")
                _eyeLookUpLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "eyeLookUpRight")
                _eyeLookUpRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "eyeLookDownLeft")
                _eyeLookDownLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "eyeLookDownRight")
                _eyeLookDownRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "eyeLookInLeft")
                _eyeLookInLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "eyeLookInRight")
                _eyeLookInRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "eyeLookOutLeft")
                _eyeLookOutLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "eyeLookOutRight")
                _eyeLookOutRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "noseSneerLeft")
                _noseSneerLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "noseSneerRight")
                _noseSneerRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthUpperUpLeft")
                _mouthUpperUpLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthUpperUpRight")
                _mouthUpperUpRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthSmileLeft")
                _mouthSmileLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthSmileRight")
                _mouthSmileRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthLeft")
                _mouthLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthRight")
                _mouthRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthDimpleLeft")
                _mouthDimpleLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthDimpleRight")
                _mouthDimpleRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthFrownLeft")
                _mouthFrownLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthFrownRight")
                _mouthFrownRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthLowerDownLeft")
                _mouthLowerDownLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthLowerDownRight")
                _mouthLowerDownRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthShrugUpper")
                _mouthShrugUpperIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthShrugLower")
                _mouthShrugLowerIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "cheekPuff")
                _cheekPuffIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthPucker")
                _mouthPuckerIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthStretchLeft")
                _mouthStretchLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthStretchRight")
                _mouthStretchRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthFunnel")
                _mouthFunnelIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthPressLeft")
                _mouthPressLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthPressRight")
                _mouthPressRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthClose")
                _mouthCloseIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthRollUpper")
                _mouthRollUpperIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "mouthRollLower")
                _mouthRollLowerIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "jawOpen")
                _jawOpenIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "jawLeft")
                _jawLeftIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "jawRight")
                _jawRightIndex = i;
            if (_skinnedMesh.GetBlendShapeName(i) == "jawForward")
                _jawForwardIndex = i;

        }

        #endregion
        
    }

    private void Update()
    {
        #region setBlendShapeWeightFromAU
        
        skinnedMeshRenderer.SetBlendShapeWeight(_browInnerUpIndex, AU1);
        skinnedMeshRenderer.SetBlendShapeWeight(_browOuterUpLeftIndex, AU2);
        skinnedMeshRenderer.SetBlendShapeWeight(_browOuterUpRightIndex, AU2);
        skinnedMeshRenderer.SetBlendShapeWeight(_browDownLeftIndex, AU4);
        skinnedMeshRenderer.SetBlendShapeWeight(_browDownRightIndex, AU4);
        skinnedMeshRenderer.SetBlendShapeWeight(_eyeWideLeftIndex, AU5);
        skinnedMeshRenderer.SetBlendShapeWeight(_eyeWideRightIndex, AU5);
        skinnedMeshRenderer.SetBlendShapeWeight(_cheekSquintLeftIndex, AU6);
        skinnedMeshRenderer.SetBlendShapeWeight(_cheekSquintRightIndex, AU6);
        skinnedMeshRenderer.SetBlendShapeWeight(_eyeSquintLeftIndex, AU7);
        skinnedMeshRenderer.SetBlendShapeWeight(_eyeSquintRightIndex, AU7);
        skinnedMeshRenderer.SetBlendShapeWeight(_eyeBlinkLeftIndex, AU45);
        skinnedMeshRenderer.SetBlendShapeWeight(_eyeBlinkRightIndex, AU45);
        skinnedMeshRenderer.SetBlendShapeWeight(_eyeLookUpLeftIndex, M63);
        skinnedMeshRenderer.SetBlendShapeWeight(_eyeLookUpRightIndex, M63);
        skinnedMeshRenderer.SetBlendShapeWeight(_eyeLookDownLeftIndex, M64);
        skinnedMeshRenderer.SetBlendShapeWeight(_eyeLookDownRightIndex, M64);
        skinnedMeshRenderer.SetBlendShapeWeight(_eyeLookInLeftIndex, AU66);
        skinnedMeshRenderer.SetBlendShapeWeight(_eyeLookInRightIndex, AU66);
        skinnedMeshRenderer.SetBlendShapeWeight(_eyeLookOutLeftIndex, AU65);
        skinnedMeshRenderer.SetBlendShapeWeight(_eyeLookOutRightIndex, AU65);
        skinnedMeshRenderer.SetBlendShapeWeight(_noseSneerLeftIndex, AU9);
        skinnedMeshRenderer.SetBlendShapeWeight(_noseSneerRightIndex, AU9);
        skinnedMeshRenderer.SetBlendShapeWeight(_mouthUpperUpLeftIndex, AU10);
        skinnedMeshRenderer.SetBlendShapeWeight(_mouthUpperUpRightIndex, AU10);
        skinnedMeshRenderer.SetBlendShapeWeight(_mouthSmileLeftIndex, AU12);
        skinnedMeshRenderer.SetBlendShapeWeight(_mouthSmileRightIndex, AU12);
        skinnedMeshRenderer.SetBlendShapeWeight(_mouthDimpleLeftIndex, AU14);
        skinnedMeshRenderer.SetBlendShapeWeight(_mouthDimpleRightIndex, AU14);
        skinnedMeshRenderer.SetBlendShapeWeight(_mouthFrownLeftIndex, AU15);
        skinnedMeshRenderer.SetBlendShapeWeight(_mouthFrownRightIndex, AU15);
        skinnedMeshRenderer.SetBlendShapeWeight(_mouthLowerDownLeftIndex, AU16);
        skinnedMeshRenderer.SetBlendShapeWeight(_mouthLowerDownRightIndex, AU16);
        skinnedMeshRenderer.SetBlendShapeWeight(_mouthShrugLowerIndex, AU17);
        skinnedMeshRenderer.SetBlendShapeWeight(_cheekPuffIndex, AD34);
        skinnedMeshRenderer.SetBlendShapeWeight(_mouthPuckerIndex, AU18);
        skinnedMeshRenderer.SetBlendShapeWeight(_mouthStretchLeftIndex, AU20);
        skinnedMeshRenderer.SetBlendShapeWeight(_mouthStretchRightIndex, AU20);
        skinnedMeshRenderer.SetBlendShapeWeight(_mouthFunnelIndex, AU22);
        skinnedMeshRenderer.SetBlendShapeWeight(_mouthPressLeftIndex, AU24);
        skinnedMeshRenderer.SetBlendShapeWeight(_mouthPressRightIndex, AU24);
        skinnedMeshRenderer.SetBlendShapeWeight(_mouthRollUpperIndex, AU28);
        skinnedMeshRenderer.SetBlendShapeWeight(_mouthRollLowerIndex, AU28);
        skinnedMeshRenderer.SetBlendShapeWeight(_jawOpenIndex, AU26);
        skinnedMeshRenderer.SetBlendShapeWeight(_jawLeftIndex, AD30);
        skinnedMeshRenderer.SetBlendShapeWeight(_jawRightIndex, AD30);
        skinnedMeshRenderer.SetBlendShapeWeight(_jawForwardIndex, AD29);
        
        #endregion
    }

    public void Anger()
    {
        Debug.Log("The facial expression turned into anger.");
    }
    
    public void Contempt()
    {
        Debug.Log("The facial expression turned into contempt.");
    }
    
    public void Disgust()
    {
        Debug.Log("The facial expression turned into disgust.");
    }
    
    public void Fear()
    {
        Debug.Log("The facial expression turned into fear.");
    }
    
    public void Happiness()
    {
        Debug.Log("The facial expression turned into happiness.");
    }
    
    public void Neutral()
    {
        Debug.Log("The facial expression turned into neutral.");
    }
    
    public void Sadness()
    {
        Debug.Log("The facial expression turned into sadness.");
    }
    
    public void Shock()
    {
        Debug.Log("The facial expression turned into shock.");
    }
    
    public void Surprise()
    {
        Debug.Log("The facial expression turned into surprise.");
    }
}