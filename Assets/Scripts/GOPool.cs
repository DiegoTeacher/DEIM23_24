using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GOPool : MonoBehaviour
{
    private List<GameObject> pool;

    [Tooltip("Objeto que se va a meter en la pool")]
    public GameObject objectToPool;
    [Tooltip("Tamaño de la pool")]
    public uint size;
    [Tooltip("Debería expandirse la pool si se vacía?")]
    public bool shouldExpand;

    // Start is called before the first frame update
    void Awake()
    {
        pool = new List<GameObject>();
        for(int i = 0; i < size; i++)
        {
            AddGameObjectToPool();
        }
    }

    GameObject AddGameObjectToPool()
    {
        GameObject obj = Instantiate(objectToPool, transform);
        obj.SetActive(false);
        pool.Add(obj);

        return obj;
    }

    public GameObject GetInactiveGameObject()
    {
        foreach(GameObject obj in pool)
        {
            if (!obj.activeInHierarchy)
            {
                return obj;
            }
        }

        // si la pool deberia expandirse en caso de que "este vacia"
        //  (el for no ha encontrado ningun objeto inactivo)
        if(shouldExpand)
        {
            // estamos haciendo un instantiate ebn ejecucion
            return AddGameObjectToPool();
        }

        return null;
    }
}
