using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileTest : MonoBehaviour
{
    public string fileName;

    private Vector3 StringToV3(string stringVector)
    {
        stringVector = stringVector.Substring(1, stringVector.Length - 2);

        string[] stringVectorDivided = stringVector.Split(',');

        for (int i = 0; i < stringVectorDivided.Length; i++)
        {
            stringVectorDivided[i] = stringVectorDivided[i].Replace('.', ',');
        }

        Vector3 nVector = new Vector3(float.Parse(stringVectorDivided[0]), float.Parse(stringVectorDivided[1]), float.Parse(stringVectorDivided[2]));

        return nVector;
    }

    // cargar
    private void Awake()
    {
        if (File.Exists(Application.persistentDataPath + "\\" + fileName))
        {
            StreamReader sr = new StreamReader(Application.persistentDataPath + "\\" + fileName);

            string filePos = sr.ReadLine();
            string fileScale = sr.ReadLine();

            sr.Close();

            Vector3 nPosition = StringToV3(filePos);
            Vector3 nScale = StringToV3(fileScale);
           
            transform.position = nPosition;  
            transform.localScale = nScale;
        }
    }

    void OnApplicationQuit()
    {

    }

    // guardar 
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            FileStream fs = File.Create(Application.persistentDataPath + "\\" + fileName);

            StreamWriter streamWriter = new StreamWriter(fs);

            streamWriter.WriteLine(transform.position.ToString());
            streamWriter.WriteLine(transform.localScale.ToString());

            streamWriter.Close();
            fs.Close();
        }
    }
}
