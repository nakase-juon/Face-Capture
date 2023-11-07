using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "SavedActionUnits", menuName = "ScriptableObject/Saved ActionUnits")]
public class SavedAU : ScriptableObject
{
    [Range(.0f, 100f)] public float AU1, AU2, AU4, AU5, AU6, AU7, 
        AU9, AU10, AU12, AU14, AU15, AU16, AU17, AU18, AU20, AU22, 
        AU23, AU24, AU25, AU26, AU28, AU45, AU65, AU66, AD29, AD30, 
        AD34, M63, M64;
    
}
