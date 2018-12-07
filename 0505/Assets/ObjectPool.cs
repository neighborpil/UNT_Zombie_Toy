using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool : MonoBehaviour {

    public List<GameObject> BulletList = new List<GameObject>();
    public GameObject BulletPrefab;
    public int InitCount;

	// Use this for initialization
	void Start () {
        Enumerable.Range(0, InitCount).ToList().ForEach(i => BulletList.Add(Instantiate(BulletPrefab, transform) as GameObject));
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < BulletList.Count(); i++)
            {
                if(!BulletList[i].activeInHierarchy)
                {
                    BulletList[i].transform.position = Vector3.zero;
                    BulletList[i].SetActive(true);
                    return;
                }
            }

            BulletList.Add(Instantiate(BulletPrefab, transform) as GameObject);
            BulletList.Last().transform.position = Vector3.zero;

            BulletList.Last().SetActive(true);
        }
	}
}
