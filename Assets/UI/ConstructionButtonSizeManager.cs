using UnityEngine;
using System.Collections;

public class ConstructionButtonSizeManager : MonoBehaviour {

	public int buttonWidth;
	public int buttonHeight;

	public void AdjustSize()
	{
		Vector2 size = this.GetComponent<RectTransform> ().sizeDelta;
		size.y = buttonHeight * this.transform.childCount;
		size.x = buttonWidth * this.transform.childCount;

		this.GetComponent<RectTransform> ().sizeDelta = size;
	}
}
