using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class JSONTest : MonoBehaviour
{
    public string jsonFileName;

    [System.Serializable]
    public struct PlayerInfo
    {
        public Vector3 position;
    }

    // Start is called before the first frame update
    void Start()
    {
        Load();
    }

    void Load()
    {
        if(File.Exists(Application.persistentDataPath + "\\" + jsonFileName))
        {
            StreamReader reader = new StreamReader(Application.persistentDataPath + "\\" + jsonFileName);
            string entireJsonFile = reader.ReadToEnd();
            PlayerInfo info = JsonUtility.FromJson<PlayerInfo>(entireJsonFile);
            transform.position = info.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            PlayerInfo info = new PlayerInfo();
            info.position = transform.position;
            StreamWriter writer = new StreamWriter(Application.persistentDataPath + "\\" + jsonFileName);
            string jsonInfo = JsonUtility.ToJson(info);
            writer.Write(jsonInfo);
            writer.Close();
        }
    }
}
