using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyNewVariableAndMethod : MonoBehaviour
{
    public int currentAge = 20;
    public int ageIncrease = 1;
    bool isFunny = true;  // or: false
    string myName = "Olga";
    //string myFirstName = "Olga";
    string mySecondName = "Timcenko";
    public int a = 512;
    public int b = 731;


    // Start is called before the first frame update
    void Start()
    {
           Debug.LogFormat("My initial values are: a={0}, b={1}", a, b);
           int c = a;
           a=b;
           b=c;
           Debug.LogFormat("My swapped values are: a={0}, b={1}", a, b);

           int d0= 10;
           int d1 = 20;
//
           (a,b) = Swap (a,b);
           Debug.LogFormat("My swapped a and b values with Swap method are: a={0}, b={1}", a, b);

           (d0, d1) = Swap (d0, d1);
           Debug.LogFormat("My swapped d0 and d1 values with Swap method are: d0={0}, d1={1}", d0, d1);

           (int m1, int m2) = Swap (1, 7);
           Debug.LogFormat("My swapped 1 and 7 values with Swap method are: {0}, {1}", m1, m2);

           (float f1, float f2) = Swap (1.5f, 7.3f);
           Debug.LogFormat("My swapped 1.5f and 7.3f values with Swap float method are: {0}, {1}", f1, f2);
           
//
    }

    /// <summary>
    /// Swaps two integers
    /// </summary>
           (int, int) Swap(int m, int n)
           {
/*
			   int temp = m;
			   m = n;
			   n = temp;
*/
               return (n, m);
		   }

    /// <summary>
    /// Swaps two floats
    /// </summary>
           (float, float) Swap(float m, float n)
           {
			   float temp = m;
			   m = n;
			   n = temp;

               return (m, n);
		   }
     
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
