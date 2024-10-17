using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norwind.Writries
{
    public class FileWriter : IUserActionWriter
    {
        public FileWriter()
        {
        }
    }

    public void Write(IUserAction action)

   
    {
        
        File.AppendAllText("AppLogs.txt",
            string.Format("FileWriter:{0},{1},{2}",
            action.CreatedDateTime, action.User, action.Description));

    }
}
