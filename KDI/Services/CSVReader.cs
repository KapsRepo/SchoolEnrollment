using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using KDI.Models;
using Microsoft.Ajax.Utilities;
using WebGrease.Css.Extensions;

namespace KDI.Services
{
    public class CSVReader
    {
        private string path = @"G:\SchoolEnrollment.csv";

        public Dictionary<string,List<SchoolEnrollment>> GetFile()
        {
            var data = new Dictionary<string, List<SchoolEnrollment>>();
            
            var header = new List<string>();
            if (File.Exists(path))
            {
                using (StreamReader sr=File.OpenText(path))
                {
                    for (int i = 0; i <= 47; i++)
                    {
                        var readLine = sr.ReadLine();
                        var lineArray = readLine.Split(',');
                        if (i == 0)
                        {
                           lineArray.ForEach(header.Add);
                            continue;
                        }
                        var enrollments = new List<SchoolEnrollment>();
                        for (int j = 1; j <= header.Count - 1; j++)
                        {
                            var enrollment = new SchoolEnrollment();
                            enrollment.Year = Convert.ToInt32(header[j]);
                            enrollment.Enrollment = Convert.ToInt32(lineArray[j]);
                            enrollments.Add(enrollment);
                        }
                     
                        data.Add(lineArray[0],enrollments);

                    }
                }
                
            }
            return data;
        }
    }
}