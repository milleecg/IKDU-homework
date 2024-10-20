using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstVariableAndMethod : MonoBehaviour
{
    public int currentAge = 20;
    public int ageIncrease = 1;
    bool isFunny = true;  // or: false
    string myName = "Olga";
    //string myFirstName = "Olga";
    string mySecondName = "Timcenko";
    public int a = 512;
    public int b = 731;

    (int, int) Swap(int m, int n)
    {
        /*
        Debug.LogFormat("m={0}, n={1}", m, n);
        int c = m;
        m = n;
        n = c;
        Debug.LogFormat("m={0}, n={1}", m, n);
        */
        return (n, m);
    }

    // Start is called before the first frame update
    void Start()
    {
        float aa=20.0f/6.0f;
        float bb=10.0f/3.0f;
          if (aa == bb)
		  {
			Debug.Log("aa and bb are equal");
		  }
		  else
		  {
			Debug.Log("aa and bb are not equal");
		  }
    
        currentAge = currentAge + ageIncrease;
          Debug.Log(currentAge);
          myName = myName + mySecondName;
          Debug.Log(myName);
        
        
        Debug.LogFormat("a={0}, b= {1}", a, b);
        (a, b) = Swap(a, b);
        Debug.LogFormat("a={0}, b= {1}", a, b);
        

    }

    // Update is called once per frame
    void Update()
    {
      /* 
       currentAge += ageIncrease;
       Debug.Log(currentAge);
      */
    }
}
