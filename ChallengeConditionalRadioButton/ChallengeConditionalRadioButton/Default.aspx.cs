using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeConditionalRadioButton
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pencilRadioButton.Checked)
            {
                resultLabel.Text = "You selected Pencil.";
                resultImage.ImageUrl = "/images/Pencil.png";
            }
            else if (penRadioButton.Checked)
            {
                resultLabel.Text = "You selected Pen.";
                resultImage.ImageUrl = "/images/Pen.png";
            }
            else if (phoneRadioButton.Checked)
            {
                resultLabel.Text = "You selected Phone.";
                resultImage.ImageUrl = "/images/Phone.png";
            }
            else if (tabletRadioButton.Checked)
            {
                resultLabel.Text = "You selected Tablet.";
                resultImage.ImageUrl = "/images/Tablet.png";
            }
            else
            {
                resultLabel.Text = "Please select one of options.";
                resultImage.ImageUrl = "";
            }
        }
    }
}