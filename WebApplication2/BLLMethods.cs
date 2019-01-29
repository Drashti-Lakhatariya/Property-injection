using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BussLayer;

namespace WebApplication2
{
    public class BLLMethods : IMethodBLL
    {
        public IBussLayer BussLayer { get; set; }

        public void InsertData(string _name, string _gender, string _dob)
        {
            BussLayer.InsertData(_name, _gender, _dob);
        }

        public void UpdateData(string _name, string _gender, string _dob)
        {
            BussLayer.UpdateData(_name, _gender, _dob);
        }

        public void DeleteData(string _name)
        {
            BussLayer.DeleteData(_name);
        }

        public object SelectData()
        {
            return BussLayer.SelectData();
        }
    }
}