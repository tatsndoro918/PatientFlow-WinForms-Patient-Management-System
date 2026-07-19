using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WFAPatientTracker.Models;

namespace WFAPatientTracker.Services
{
    public class PatientService
    {
        private const string FilePath = "Data/patients.json";

        public List<Patient> LoadPatients()
        {
            if (!File.Exists(FilePath))
                return new List<Patient>();

            string json = File.ReadAllText(FilePath);

            return JsonSerializer.Deserialize<List<Patient>>(json)
                   ?? new List<Patient>();
        }

        public void SavePatients(List<Patient> patients)
        {
            string json = JsonSerializer.Serialize(
                patients,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            string directory = Path.GetDirectoryName(FilePath)!;

            Directory.CreateDirectory(directory);

            File.WriteAllText(FilePath, json);
        }
    }
}
