using System;
using System.IO;

namespace SettingsManager
{
    public abstract class Setting<T> where T : Setting<T>, new()
    {
        private static readonly string FilePath = SettingsManager.GetLocalFilePath($"{typeof(T).Name}.json");

        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance is null)
                {
                    Load();
                }

                return _instance ?? throw new InvalidOperationException("Something probably went horribly wrong if this error is thrown.");
            }
        }

        public static void Load()
        {
            var fileExists = File.Exists(FilePath);
        
            _instance = (fileExists
                ? System.Text.Json.JsonSerializer.Deserialize<T>(File.ReadAllText(FilePath))
                : new T()) ?? new T();

            if (!fileExists)
            {
                Save();
            }
        }

        public static void Save()
        {
            var json = System.Text.Json.JsonSerializer.Serialize(Instance);

            var directoryName = Path.GetDirectoryName(FilePath);

            if (directoryName is null)
            {
                throw new InvalidOperationException("directoryName is null");
            }
            
            Directory.CreateDirectory(directoryName);
            File.WriteAllText(FilePath, json);
        }
    }
}