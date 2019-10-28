using System;
using System.Collections.Generic;
using System.Text;
using CompassSPAPP.Layers.Data;

namespace CompassSPAPP.Layers.Data
{
    public class ResultData
    {
        private Config.DbConnection _dbConn;

        public ResultData()
        {
            _dbConn = new Config.DbConnection();
            _dbConn.Connection.CreateTable<Model.Result>();
        }

        public Model.Result Get()
        {
            return _dbConn.Connection.Table<Model.Result>().FirstOrDefault();
        }

        public void Insert(Model.Result _Result)
        {
            _dbConn.Connection.Insert(_Result);
        }


        public void Update(Model.Result _Result)
        {
            _dbConn.Connection.Update(_Result);
        }

        public void Delete(Model.Result _Result)
        {
            _dbConn.Connection.Delete(_Result);
        }

        public void DropTable()
        {
            _dbConn.Connection.DropTable<Model.Result>();
        }
    }
}
