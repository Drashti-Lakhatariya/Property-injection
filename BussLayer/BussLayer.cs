using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BussLayer
{
    public class BussLayer : IBussLayer
    {
        public IDataAccess _objDAL { get; set; }

        public void InsertData(string _name, string _gender, string _dob)
        {
            _objDAL.InsertData(_name, _gender, _dob);
        }

        public void UpdateData(string _name, string _gender, string _dob)
        {
            _objDAL.UpdateData(_name, _gender, _dob);
        }

        public void DeleteData(string _name)
        {
            _objDAL.DeleteData(_name);
        }

        public object SelectData()
        {
            return _objDAL.SelectData();
        }
    }
}
