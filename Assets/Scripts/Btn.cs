using UnityEngine;

public class Btn : MonoBehaviour
{
    
	// Use this for initialization
	void Start ()
	{
	    //print("creating stuff");
	    gen(13, 0, 0.5f, 0);
	}

    //private bool started = false, waitStart = false;

    void gen(int k, float x, float y, float z)
    {
        //hmm
        //x, y, z is the bottom left of the stack
        float ly = y, bz = 0.0f;
        for (int i = 0; i < k; i++)
        {
            float lx = x, lz = z;
            for (int j = 0; j < 3; j++)
            {
                //generate 3 with rotation respect to i%2
                bool v = (i % 2 == 0);
                Quaternion rot = Quaternion.identity;
                if (!v) rot = Quaternion.AngleAxis(90, Vector3.up);
                GameObject obj = (GameObject) Instantiate(Resources.Load("Cubey"), new Vector3(lx - (i % 2) * bz, ly, lz + (i % 2) * bz), rot);
                bz = obj.transform.lossyScale.z;
                if (!v) lx += obj.transform.lossyScale.z;
                else lz += obj.transform.lossyScale.z;
                if (j == 2) ly += (obj.transform.lossyScale.y);
            }
        }
    }
	//bool crouching = false;


	// Update is called once per frame
	void Update () {

	    /*if (Input.GetKeyDown(KeyCode.C))
	    {
	        if (crouching)
	        {
	            crouching = false;
	        }
	        else
	        {
	            crouching = true;
	        }
	    }

	    Vector3 cs = this.gameObject.transform.localScale;


        if (crouching)
        {
            this.gameObject.transform.localScale = new Vector3(cs.x, 0.25f, cs.z);
        }
	    else
        {
            this.gameObject.transform.localScale = new Vector3(cs.x, 0.75f, cs.z);
        }

	    if (Input.GetKeyDown(KeyCode.E))
	    {
	        //use
	        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
	        if (Physics.Raycast(ray, out hit) && hit.collider.name == "Start")
	        {
	            if (started || waitStart) return;
	            waitStart = true;
	        }
	    }

	    if (Input.GetKeyDown(KeyCode.F))
	    {
	        
	        //use
	        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	        RaycastHit hit;
	        if (Physics.Raycast(ray, out hit) && hit.collider.name == "Cube")
	        {
	            if (!waitStart) return;
	            waitStart = false;
	            //started = true;
	            gen(20, hit.point.x, hit.point.y, hit.point.z);
	        }
        }*/
	}
}
