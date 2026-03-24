using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using JogoDeCartas.Models;

namespace JogoDeCartas.Services
{
    public class StorageService
    {
        private readonly string _filePath = "game_history.json";

        public void SaveMatch(Match match)
        {
            List<Match> history = LoadHistory();
            history.Add(match);

            string json = JsonSerializer.Serialize(history, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }

        public List<Match> LoadHistory()
        {
            if (!File.Exists(_filePath)) return new List<Match>();

            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Match>>(json) ?? new List<Match>();
        }
    }
}