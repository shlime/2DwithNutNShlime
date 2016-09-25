using UnityEngine;
using System.Collections;

public class BuildManager : MonoBehaviour {

	bool IsBuilding = false;
	GameObject building;

	void Update()
	{
		if (IsBuilding) {
			Vector3 vect = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			building.transform.position = new Vector3 (vect.x, vect.y, -4);
		}
	}


	// 	TODO: That's not what we want. 
	public void SetMode_BuildBuilding(GameObject go)
	{
		if (building) {
			return;
		}
		IsBuilding = true;

		building = (GameObject)Instantiate (go, new Vector3(0, 0, -4), Quaternion.identity);
	}

}
