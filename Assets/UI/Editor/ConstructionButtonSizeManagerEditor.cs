using UnityEngine;
using UnityEditor;
using System.Collections;


[CustomEditor(typeof(ConstructionButtonSizeManager))]
public class ConstructionButtonSizeManagerEditor : Editor {

	public override void OnInspectorGUI()
	{
		DrawDefaultInspector ();

		if (GUILayout.Button ("Resize Buttons")) {
			ConstructionButtonSizeManager cbsm = ((ConstructionButtonSizeManager) target);
			cbsm.AdjustSize();
		}

	}

}
