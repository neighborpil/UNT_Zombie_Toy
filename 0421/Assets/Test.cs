using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using System.Linq;
using UnityEngine;

public class Test : MonoBehaviour {

    public int[] Score;
    public int[] Score2;

    public IEnumerator CoroutimeFunction1;
    public IEnumerator CoroutimeFunction2;

    // Use this for initialization
    void Start () {
        //Score2 = new int[5] { 1,2,3,4,5 };
        //Enumerable.Range(0, 5).ToList().ForEach(i => Debug.Log(Score[i]));
        CoroutimeFunction1 = Sample(1, 2);
        CoroutimeFunction2 = Sample(3, 4);
        StartCoroutine(CoroutimeFunction1);
        StartCoroutine(CoroutimeFunction2);
        //StartCoroutine("Sample", 5);
        //StartCoroutine("Sample", 3);
    }
	
	// Update is called once per frame
	void Update () {
        //UnityEngine.Debug.Log("Update");
        //StopCoroutine("Sample");
        //StopCoroutine("Sample");
        //if (Input.GetMouseButtonDown(0)) // 0 : 좌클릭, 1 : 우클릭
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StopAllCoroutines();
            //StopCoroutine(CoroutimeFunction1);

            //StopCoroutine("Sample");
        }
        if(Input.GetMouseButtonDown(1))
            StopCoroutine(CoroutimeFunction2);

    }

    IEnumerator Sample(int a, int b)
    {
        //var s = Stopwatch.StartNew();
        //s.Start();
        //UnityEngine.Debug.Log("Coroutine Start / " + Time.time);
        while (true)
        {
            Debug.Log(a + ", " + b);
            yield return null;
        }
        //Debug.Log(a);
        //yield return new WaitForSeconds(3);
        //s.Stop();
        //UnityEngine.Debug.Log("Coroutine End / " + Time.time);

        //Debug.Log("Coroutine Start");
        //yield return null;
        //Debug.Log("Coroutine End");
    }
}
