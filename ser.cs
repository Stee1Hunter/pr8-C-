using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class DataSerializer
{
    public void Serialize<T>(T data)
    {
        string json = JsonConvert.SerializeObject(data);
        string desctop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string path = desctop + "/json.json";
        File.WriteAllText(path, json);
        return;
    }

    public T Deserialize<T>(string jsonData)
    {
        return JsonConvert.DeserializeObject<T>(jsonData);
    }
}