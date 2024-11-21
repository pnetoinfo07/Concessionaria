using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio._02_Repository;

public static class InicializadorBD
{
    private const string ConnectionString = "Data Source=Concessionaria.db";
    public static void Inicializar()
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();

            string commandoSQL = @"   
                 CREATE TABLE IF NOT EXISTS Carros(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Modelo TEXT NOT NULL,
                 Ano INTEGER NOT NULL,
                 CapacidadeTanque REAL NOT NULL,
                 ConsumoPorKm REAL NOT NULL,
                 Tipo TEXT NOT NULL
                );";
            commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS Caminhoes(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Modelo TEXT NOT NULL,
                 Ano INTEGER NOT NULL,
                 CapacidadeTanque REAL NOT NULL,
                 ConsumoPorKm REAL NOT NULL,
                 CapacidadeCarga REAL NOT NULL
                );";

            connection.Execute(commandoSQL);
        }
    }
}
