using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCe
{
    public class SQLCe
    {
        SqlCeConnection conn = null;

        public SQLCe()
        {
            //
        }

        public void Connect(string connectionString) {
            // ("Data Source = MyDatabase.sdf; Password ='<pwd>'")
            conn = new SqlCeConnection(connectionString);
        }

        public void Select() {
            //
        }

        public List<string> GetInfos(string info)
        {
            List<string> ret = new List<string>();

            using (SqlCeCommand cmd = conn.CreateCommand())
            {
                conn.Open();

                ret.Add(info + " Database: " + conn.Database);
                ret.Add(info + " DatabaseIdentifier: " + conn.DatabaseIdentifier);
                ret.Add(info + " DataSource: " + conn.DataSource);
                var dbInfo = conn.GetDatabaseInfo();
                foreach (var item in dbInfo)
                {
                    //item.Key
                    ret.Add(info + " DatabaseInfo: " + item.Key + " " + item.Value);
                }
                ret.Add(info + " ServerVersion: " + conn.ServerVersion);

                var schema = conn.GetSchema();
                var rows = schema.Rows;
                for (int i = 0; i < rows.Count; i++)
                {
                    // schema.Rows[0].ItemArray[0]
                    var item0 = rows[i].ItemArray[0];

                    ret.Add(info + " Schema: " + item0.ToString());
                }
                //ret.Add("Site.Name" + conn.Site.Name);    // conn.Site=null

                // File Size
                string filename = conn.DataSource;
                System.IO.FileInfo fi = new System.IO.FileInfo(filename);
                ret.Add(info + " FileSize: " + fi.Length.ToString());

                conn.Close();
            }

            return ret;
        }

        public List<string> GetSchemas(){
            List<string> ret = new List<string>();

            //
            // SELECT * FROM INFORMATION_SCHEMA.COLUMNS	-- (292 rows affected)
            // SELECT * FROM INFORMATION_SCHEMA.INDEXES order by TABLE_NAME, INDEX_NAME 	-- (23 rows affected)
            // SELECT * FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE	-- (0 row affected)
            // SELECT * FROM INFORMATION_SCHEMA.PROVIDER_TYPES	-- (18 rows affected)
            // SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS	-- (0 row affected)
            // SELECT * FROM INFORMATION_SCHEMA.TABLES	-- (22 rows affected)
            // SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS	-- (0 row affected)
            // SELECT * FROM sys.lock_information	-- (0 row affected)
            // SELECT * FROM __SysObjects order by [0],[1],[5],[2]	-- (325 rows affected), (314 rows affected)
            // SELECT [0], count(1) FROM __SysObjects group by [0]
            // -- 1	22
            // -- 2	11
            // -- 4	292

            ret.Add("INFORMATION_SCHEMA.TABLES");
            ret.Add("INFORMATION_SCHEMA.COLUMNS");
            ret.Add("INFORMATION_SCHEMA.INDEXES");
            // INFORMATION_SCHEMA.PROVIDER_TYPES
            // SELECT * FROM __SysObjects order by [1],[5],[2]

            //using (SqlCeCommand cmd = conn.CreateCommand()){
            //    conn.Open();

            //    var schema = conn.GetSchema();
            //    var rows = schema.Rows;
            //    for (int i = 0; i < rows.Count; i++){
            //        var item0 = rows[i].ItemArray[0];
            //        ret.Add(item0.ToString());
            //    }

            //    conn.Close();
            //}

            return ret;
        }

        public List<string> GetTables()
        {
            List<string> ret = new List<string>();

            string sql = "SELECT * FROM INFORMATION_SCHEMA.TABLES order by TABLE_NAME";

            using ( SqlCeCommand cmd = conn.CreateCommand() ){
                conn.Open();

                cmd.CommandText = sql;
                using( SqlCeDataReader rd = cmd.ExecuteReader() )
                {
                    while (rd.Read())
                    {
                        var tableName = rd.GetString(2);
                        ret.Add(tableName);
                    }
                }

                conn.Close();
            }

            return ret;
        }

        public int GetRecCount(string tableName)
        {
            int ret = -1;

            string sql = "select count(1) from " + tableName;

            using (SqlCeCommand cmd = conn.CreateCommand())
            {
                conn.Open();

                cmd.CommandText = sql;
                using (SqlCeDataReader rd = cmd.ExecuteReader())
                {
                    rd.Read();

                    var recCount = (int)rd[0];
                    ret = recCount;
                }

                conn.Close();
            }

            return ret;
        }

        public List<string> DumpData(string tableName, string delimiter) {
            List<string> ret = new List<string>();

            string sql = "select * from " + tableName;

            using (SqlCeCommand cmd = conn.CreateCommand()){
                conn.Open();

                cmd.CommandText = sql;
                using (SqlCeDataReader rd = cmd.ExecuteReader()){
                    while (rd.Read())
                    {
                        string row = "";
                        for (int i = 0; i < rd.FieldCount; i++)
                        {
                            var col = rd.GetValue(i);

                            if (row!="") { row += delimiter; }
                            row += col;
                        }
                        ret.Add(row);
                    }
                }

                conn.Close();
            }

            return ret;
        }
    }
}
