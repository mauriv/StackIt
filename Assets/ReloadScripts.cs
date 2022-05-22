
using UnityEditor;
using UnityEngine;
 
public class ReloadScripts : MonoBehaviour
{
    public bool ReloadOnExitPlayMode;
 
    public void OnDestroy()
    {
        if (ReloadOnExitPlayMode) EditorApplication.delayCall += EditorUtility.RequestScriptReload;
    }
}
