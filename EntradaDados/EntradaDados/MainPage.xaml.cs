using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EntradaDados
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            //lbNome.Text += "\n" + TxtNome.Text;
            if (TxtNome.Text != null)
            {
                lbNome.Text += "\n" + TxtNome.Text;
            }
            else
            {
                DisplayAlert("Atenção", "Preencha o campo Nome", "Ok");
            }
            if (SwitchEnviaEmail.On)
            {
                if (TxtEmail.Text == null)
                {
                    DisplayAlert("Atenção", "Preencha o campo E-Mail", "Ok");
                }
                else
                {
                    lbNome.Text += "\n" + TxtEmail.Text;
                }

            }

            if (pck1.SelectedItem == null)
            {
                DisplayAlert("Atenção", "Escolha uma das opções de lazer", "Ok");
            }
            else
            {
                lbNome.Text += "\n" + pck1.SelectedItem;
            }

        }

        private void BtLimpar(object sender, EventArgs e)
        {
            lbNome.Text = null;
            TxtEmail.Text = null;
            TxtNome.Text = null;
            pck1.SelectedIndex = 0;
        }

        private void swt(object sender, ToggledEventArgs e)
        {
            if (SwitchEnviaEmail.On)
            {
                TxtEmail.IsEnabled = true;
            }
            else
            {
                TxtEmail.Text = null;
                TxtEmail.IsEnabled = false;
            }
        }
    }
}
