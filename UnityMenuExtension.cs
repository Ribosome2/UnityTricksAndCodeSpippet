using UnityEngine;
using System.Collections;
using UnityEditor;
public class KyleEditorTool : Editor {

	
    //路径在GameObject下面，选择GameObject之后右键也会显示菜单
    [MenuItem("GameObject/CopyName", false, 0)] 
    public static void CopyGameObjectName()
    {
        Debug.Log("kkkk");
        if (Selection.activeGameObject)
        {
            CopyToClipboard(Selection.activeGameObject.name);
        }
    }

    public static void CopyToClipboard(string str)
    {
        TextEditor te = new TextEditor();
        te.text = str;
        te.OnFocus();
        te.Copy();
    }
}
