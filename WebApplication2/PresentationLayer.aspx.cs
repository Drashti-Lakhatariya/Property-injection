using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussLayer;
using DataAccess;


namespace WebApplication2
{
    public partial class PresentationLayer : System.Web.UI.Page
    {
        private IMethodBLL objBLL;


        public PresentationLayer()
        {
            objBLL = new BLLMethods()
            {
                BussLayer = new BussLayer.BussLayer()
                {
                    _objDAL = new DataAccess.DataAccess()
                }
            };
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            objBLL.InsertData(txtname.Text, txtgender.Text, txtdob.Text);

            GridView1.DataSource = objBLL.SelectData();
            GridView1.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            objBLL.UpdateData(txtname.Text, txtgender.Text, txtdob.Text);

            GridView1.DataSource = objBLL.SelectData();
            GridView1.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            objBLL.DeleteData(txtname.Text);

            GridView1.DataSource = objBLL.SelectData();
            GridView1.DataBind();
        }
    }
}