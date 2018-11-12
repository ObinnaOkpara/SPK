using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPK.UserControls.Buttons
{
    public partial class ButtonWithoutMenu : UserControl
    {
        public Color NormalColor;

        private Color _SideColor = Color.FromArgb(0, 125, 113);
        private Color _HoverColor { get; set; } = Color.FromArgb(8, 15, 23);
        private Image _Icon { get; set; } = Properties.Resources.icons8_person_64;
        private string _BtnText { get; set; } = "Button";

        public Color SideColor
        {
            get { return _SideColor; }
            set
            {
                _SideColor = value;
                NotifyPropertyChanged("SideColor");
            }
        }

        public Color HoverColor
        {
            get { return _HoverColor; }
            set
            {
                _HoverColor = value;
                NotifyPropertyChanged("HoverColor");
            }
        }

        public Image Icon
        {
            get { return _Icon; }
            set
            {
                _Icon = value;
                NotifyPropertyChanged("Icon");
            }
        }
        
        public string BtnText
        {
            get { return _BtnText; }
            set
            {
                _BtnText = value;
                NotifyPropertyChanged("BtnText");
            }
        }

        private void NotifyPropertyChanged(string Property)
        {
            switch (Property)
            {
                case "SideColor":
                    panel1.BackColor = SideColor;
                    break;

                case "Icon":
                    imgLeft.Image = _Icon;
                    break;

                case "BtnText":
                    label1.Text = _BtnText;
                    break;
                    
                default:
                    break;
            }
        }

        public ButtonWithoutMenu()
        {
            InitializeComponent();
            panel1.BackColor = SideColor;
            imgLeft.Image = _Icon;
            label1.Text = _BtnText;
        }

        private void ButtonWithoutMenu_Load(object sender, EventArgs e)
        {
            NormalColor = BackColor;
            imgLeft.Top = (Height - imgLeft.Height) / 2;
        }

        private void panTop_MouseHover(object sender, EventArgs e)
        {
            panel1.Visible = true;
            BackColor = HoverColor;
        }

        private void panTop_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = false;
            BackColor = NormalColor;
        }
    }
}
