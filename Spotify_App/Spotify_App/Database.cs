﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Spotify_App
{
    internal class Database
    {
        
        private Database() { } 
        public string server { get; set; } 
        public string databaseName { get; set; } 
        public string userName { get; set; } 
        public string password { get; set; } 
        public MySqlConnection Connection { get; set; } 
        private static Database _instance = null; 
        public static Database Instance() { 
            if (_instance == null) _instance = new Database(); 
            return _instance; } 
        public bool IsConnect() { 
            if (Connection == null) { 
                if (string.IsNullOrEmpty(databaseName)) return false; 
                string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", server, databaseName, userName, password); Connection = new MySqlConnection(connstring); 
                Connection.Open(); 
            } return true; } 
        public void Close() { Connection.Close(); 
        } 
    } 
}
