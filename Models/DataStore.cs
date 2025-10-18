using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GestionDocentes.Models
{
    public static class DataStore
    {
        private static string DataFile => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "docentes.json");

        public static BindingList<Docente> Load()
        {
            try
            {
                if (!File.Exists(DataFile)) return new BindingList<Docente>();
                var json = File.ReadAllText(DataFile);
                var list = JsonSerializer.Deserialize<List<Docente>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return list != null ? new BindingList<Docente>(list) : new BindingList<Docente>();
            }
            catch
            {
                return new BindingList<Docente>();
            }
        }

        public static void Save(BindingList<Docente> docentes)
        {
            try
            {
                var list = new List<Docente>(docentes);
                var json = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(DataFile, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error guardando datos: " + ex.Message);
            }
        }
    }
}
