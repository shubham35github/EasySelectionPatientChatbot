using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace EasySelectionPatientChatbot
{
    class EasySelectionPatientChatbot :IEasySelectionChatbot
    {
        void CreateDatabase()
        {
            /*// Excel File Path Location
            string excelfilepath = @"C:\Users\rakesh.kumar\Documents\employee.xls";

            // SQL Server TableName
            string TableName = "PatientMonitorsSample";

            // Make Sure Your Sheet Name And Columns Names Are Correct, here sheet name is sheet4
            //string exceldataquery = "select monitors_no,measurment,touchscreen,category    portablity_1 feature_1   size_1 feature_2   feature_3 portablity_2    ante / intrapartum    display_mode weights feature_4 invasive_bp co2_measurment nbp_measurment  speed storage_size from [Sheet1$]";

            string exceldataquery = "select monitors_no,measurnment from [Sheet1$]";
            try
            {
                // Excel Connection String and SQL Server Connection String
                string excelconnectionstring = @"provider=microsoft.jet.oledb.4.0;
                      data source=" + excelfilepath +
                      ";extended properties=" + "\"excel 4.0;hdr=yes;\"";
                string sqlconnectionstring = @"server=(localdb)\ProjectsV13; 
                    database = EasySelectionPatientChatbotSample; connection reset = false";

                //Execute A Query To Drase Any Previous Data From Employee Table
                string deletesqlquery = "delete from " + TableName;
                SqlConnection sqlconn = new SqlConnection(sqlconnectionstring);
                SqlCommand sqlcmd = new SqlCommand(deletesqlquery, sqlconn);

                sqlconn.Open();
                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();

                // Build A Connection To Excel Data Source And Execute The Command
                OleDbConnection oledbconn = new OleDbConnection(excelconnectionstring);
                OleDbCommand oledbcmd = new OleDbCommand(exceldataquery, oledbconn);
                oledbconn.Open();
                OleDbDataReader dr = oledbcmd.ExecuteReader();

                // Connect To SQL Server DB And Perform a Bulk Copy Operation
                SqlBulkCopy bulkcopy = new SqlBulkCopy(sqlconnectionstring);

                // Provide Excel To Table Column Mapping If Any Difference In Name
                bulkcopy.ColumnMappings.Add("FirstName", "FirstName");
                bulkcopy.ColumnMappings.Add("LastName", "LastName");
                bulkcopy.ColumnMappings.Add("Department", "Department");
                bulkcopy.ColumnMappings.Add("Gender", "Gender");

                // Provide The Table Name For Bulk Copy
                bulkcopy.DestinationTableName = TableName;

                while (dr.Read())
                {
                    bulkcopy.WriteToServer(dr);
                }

                oledbconn.Close();
            }
            catch (Exception ex)
            {
                //handle exception
            }*/
        }
        string ReadDatabase()
        {
            return "";
        }
        void DisplayItems()
        {

        }
        void ResetItems()
        {

        }
        void AbortApplication()
        {

        }
        void BackPropagation()
        {

        }

        void IEasySelectionChatbot.CreateDatabase()
        {
            throw new NotImplementedException();
        }

        string IEasySelectionChatbot.ReadDatabase()
        {
            throw new NotImplementedException();
        }

        void IEasySelectionChatbot.DisplayItems()
        {
            throw new NotImplementedException();
        }

        void IEasySelectionChatbot.ResetItems()
        {
            throw new NotImplementedException();
        }

        void IEasySelectionChatbot.AbortApplication()
        {
            throw new NotImplementedException();
        }

        void IEasySelectionChatbot.BackPropagation()
        {
            throw new NotImplementedException();
        }
    }
}
