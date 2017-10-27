using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckOver : MonoBehaviour {
	static HashSet<int> thing;
	// Use this for initialization
	void Start () {
		if (thing == null) thing = new HashSet<int>();
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.transform.position.y < 0.05f)
		{
			thing.Add(this.GetHashCode());
		}
		if (thing.Count > 3)
		{
            ((GameObject)GameObject.Find("DeadText")).GetComponent<Text>().text = "Game Over";
        }
	}
}
