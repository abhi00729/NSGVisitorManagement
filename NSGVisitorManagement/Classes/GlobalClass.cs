using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Drawing;
using System.ComponentModel;

namespace NSGVisitorManagement.Classes
{
    public enum MasterTypes
    {
        States,
        Cities,
        Users,
        IdentityTypes,
        Relationships,
        Ranks,
        Units,
        QuarterTypes
    }

    class GlobalClass
    {
        public static string DefaultComboValue = "---Select---";
        private static string machineName;
        private static Int32 loggedInUserID;
        private static string buildVersion;
        private static string employeeName;
        private static string productName;
        private static Image visitorImage;
        private static string loggedInUserRank;
        private static string loggedInUserUnit;
        private static string printerName;
        private static int defaultPassValidHours;
        private static int maxSearchRows;

        public static string MachineName
        {
            get
            {
                return machineName;
            }
            set
            {
                machineName = value;
            }
        }

        public static string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }

        public static string BuildVersion
        {
            get
            {
                return buildVersion;
            }
            set
            {
                buildVersion = value;
            }
        }

        public static Int32 LoggedInUserID
        { 
            get
            {
                return loggedInUserID;
            }
            set
            {
                loggedInUserID = value;
            }
        }

        public static string EmployeeName
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }

        public static string LoggedInUserRank
        {
            get
            {
                return loggedInUserRank;
            }
            set
            {
                loggedInUserRank = value;
            }
        }

        public static string LoggedInUserUnit
        {
            get
            {
                return loggedInUserUnit;
            }
            set
            {
                loggedInUserUnit = value;
            }
        }

        public static Image VisitorImage
        {
            get
            {
                return visitorImage;
            }
            set
            {
                visitorImage = value;
            }
        }

        public static string PrinterName
        {
            get
            {
                return printerName;
            }
            set
            {
                printerName = value;
            }
        }

        public static int DefaultPassValidHours
        {
            get
            {
                return defaultPassValidHours;
            }
            set
            {
                defaultPassValidHours = value;
            }
        }

        public static int MaxSearchRows
        {
            get
            {
                return maxSearchRows;
            }
            set
            {
                maxSearchRows = value;
            }
        }

        public static DataTable ConvertToDataTable<T>(IList<T> data, bool treatEmptyStringAsNull = false)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    if (prop.PropertyType == typeof(string) && treatEmptyStringAsNull)
                    {
                        row[prop.Name] = (prop.GetValue(item).ToString() == string.Empty ? DBNull.Value : prop.GetValue(item));
                    }
                    else
                    {
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    }
                }
                table.Rows.Add(row);
            }
            return table;
        }
    }
}


