using UnityEngine;
using System.Collections;
using UnityEditor;
[InitializeOnLoad]
public class HierachyUI {
    
    static HierachyUI() {
        EditorApplication.hierarchyWindowItemOnGUI += HierarchyWindowItemGui;
    }
	

    static void HierarchyWindowItemGui(int instanceID, Rect selectionRect){
       GameObject go=  EditorUtility.InstanceIDToObject(instanceID) as GameObject;
       bool selected = Selection.activeObject == go;
      
		//实际用的时候可以根据GameObject上面是否有某种Component或者其他条件来选择是否绘制这个对象的内容
       GUIStyle style = GUI.skin.label;
       GUIContent content = new GUIContent(go.name);
        float width = style.CalcSize(content).x;
        selectionRect.x = selectionRect.xMax- width;
        //Debug.Log("X max"+selectionRect.xMax+"X w"+width);
       Color defaltColor = GUI.color;
       GUI.color = selected ? Color.green : Color.cyan;

       GUI.Label(selectionRect, go.name);

       GUI.color = defaltColor;
    }
}
