using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [System.Serializable]
    public struct VariableGroup
    {
        public float testFloat;
        public int testInt;

        public VariableGroup(float a_TestFloat, int a_TestInt)
        {
            testFloat = a_TestFloat;
            testInt = a_TestInt;
        }
    }
    public VariableGroup m_Variables;

    // Start is called before the first frame update
    void Start()
    {
        List<Pokemon> list = new List<Pokemon> ();
        Charmander pok1 = new Charmander();
        Bulbasaur pok2 = new Bulbasaur();

        list.Add (pok2);
        list.Add (pok1);
        
        //foreach(Pokemon pok in list) {
        //    pok.Attack();
        //}
        for(int i = 0; i < list.Count; i++)
        {
            list[i].Attack();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
