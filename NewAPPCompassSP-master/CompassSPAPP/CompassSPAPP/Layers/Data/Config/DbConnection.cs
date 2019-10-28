﻿using System;
using System.IO;
using Xamarin.Forms;


namespace CompassSPAPP.Layers.Data.Config
{
    public class DbConnection: IDisposable
    {
        public SQLite.SQLiteConnection Connection { get; }

        public DbConnection()
        {
            var config = DependencyService.Get<IDBConfig>();
            var caminhoArquivoBanco = Path.Combine(config.Path, "spcompass.db");
            Connection = new SQLite.SQLiteConnection(caminhoArquivoBanco);
        }

        public void Dispose(){
            if (Connection != null) {
                Connection.Dispose(); // Liberar a conexão
            }
        }
    }
}
