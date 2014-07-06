using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox[] myTextBox = new TextBox[5];
        myTextBox[0] = TextBox1;
        myTextBox[1] = TextBox2;
        myTextBox[2] = TextBox3;
        myTextBox[3] = TextBox4;
        myTextBox[4] = TextBox5;
        TextBox6.Text = GridView1.Rows[2].Cells[4].Text;
        TextBox6.Text = GridView1.Rows.Count.ToString();
        
        for (int i = 0; i < 5; i++)
        {
            myTextBox[i].Text = i.ToString();
        }
        myTextBox[1].Text = "111\r222";
    }
}