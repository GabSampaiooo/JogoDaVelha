namespace JogoDaVelha
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
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            /* Verificando se o X ganhou */
            if ((btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X") || //Linha 1
                (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X") || //Linha 2
                (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X") || //Linha 3

                (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X") || //Coluna 1
                (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X") || //Coluna 2
                (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X") || //Coluna 3

                (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X") || //Diagonal 1
                (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")) //Diagonal 2

            {
                DisplayAlert("Parabéns!", "O 'X' ganhou!", "OK");
                Zerar();
                
            }

            /* Verificando se o O ganhou */
            if ((btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O") || //Linha 1
                (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O") || //Linha 2
                (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O") || //Linha 3

                (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O") || //Coluna 1
                (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O") || //Coluna 2
                (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O") || //Coluna 3

                (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O") || //Diagonal 1
                (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")) //Diagonal 2
            {
                DisplayAlert("Parabéns!", "O 'O' ganhou!", "OK");
                Zerar();
                
            }

            /* Verificando se deu VELHA*/
            if (verificacaoVelha())
            {
                DisplayAlert("Deu Velha", "O jogo empatou", "OK");
                Zerar();
            }

        }//Fecha método

        private bool verificacaoVelha() //Verifica se os botões estão desabilitados (Jogo Finalizado)
        {
            return !btn10.IsEnabled && !btn11.IsEnabled && !btn12.IsEnabled &&
                   !btn20.IsEnabled && !btn21.IsEnabled && !btn22.IsEnabled &&
                   !btn30.IsEnabled && !btn31.IsEnabled && !btn32.IsEnabled;
        }//não deixar de verificar

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

            vez = "X";
        }//Fecha método2

    }//Fecha Classe
}//Fecha Namespace
