using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BussLayer
{
    public interface IBussLayer
    {
        IDataAccess _objDAL { get; set; }
        void InsertData(string _name, string _gender, string _dob);
        void UpdateData(string _name, string _gender, string _dob);
        void DeleteData(string _name);
        object SelectData();
    }
}
