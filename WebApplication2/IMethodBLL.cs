using BussLayer;

namespace WebApplication2
{
    internal interface IMethodBLL
    {
        IBussLayer BussLayer { get; set; }
        void InsertData(string _name, string _gender, string _dob);
        void UpdateData(string _name, string _gender, string _dob);
        void DeleteData(string _name);
        object SelectData();
    }
}