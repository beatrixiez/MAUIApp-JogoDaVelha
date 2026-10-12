namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if (vez == "X") 
            {
                btn.Text = "X";
                vez = "O";
            } else
            {
                btn.Text = "O";
                vez = "X";
            }

            bool ganhou = false;

            // linhas
            // linha 1
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X") 
            {
                DisplayAlertAsync("Parabéns!", "O X ganhou!", "Fechar");
                ganhou = true;
                Zerar();
            } else if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O 'O' ganhou!", "Fechar");
                ganhou = true;
                Zerar();
            }

            // linha 2
            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O X ganhou!", "Fechar");
                ganhou = true;
                Zerar();
            } else if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O 'O' ganhou!", "Fechar");
                ganhou = true;
                Zerar();
            }

            // linha3
            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O X ganhou!", "Fechar");
                ganhou = true;
                Zerar();
            } else if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O 'O' ganhou!", "Fechar");
                ganhou = true;
                Zerar();
            }

            // colunas
            // coluna 1
            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O X ganhou!", "Fechar");
                ganhou = true;
                Zerar();
            }
            else if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O 'O' ganhou!", "Fechar");
                ganhou = true;
                Zerar();
            }

            // coluna 2
            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O X ganhou!", "Fechar");
                ganhou = true;
                Zerar();
            }
            else if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O 'O' ganhou!", "Fechar");
                ganhou = true;
                Zerar();
            }

            // coluna 3
            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O X ganhou!", "Fechar");
                ganhou = true;
                Zerar();
            }
            else if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O 'O' ganhou!", "Fechar");
                ganhou = true;
                Zerar();
            }

            // diagonais
            // diagonal 1
            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O X ganhou!", "Fechar");
                ganhou = true;
                Zerar();
            }
            else if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O 'O' ganhou!", "Fechar");
                ganhou = true;
                Zerar();
            }

            // diagonal 2
            if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O X ganhou!", "Fechar");
                ganhou = true;
                Zerar();
            }
            else if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O 'O' ganhou!", "Fechar");
                ganhou = true;
                Zerar();
            }

            if (!ganhou && !btn10.IsEnabled && !btn11.IsEnabled && !btn12.IsEnabled && !btn20.IsEnabled && !btn21.IsEnabled && !btn22.IsEnabled && !btn30.IsEnabled && !btn31.IsEnabled && !btn32.IsEnabled)
            {
                DisplayAlertAsync("Deu Velha!", "Ninguém ganhou desta vez.", "Fechar");
                Zerar();
            }
        }

        void Zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;
        }
    }
}
