namespace ExamenCristinaRamos
{
    public partial class Form1 : Form
    {
        //Declaracion de variables

        private int vecesGanadasJugador;
        private int vecesGanadasMaquina;
        private int tiempoRestante;
        private int randomNum;

        private List<String> opcionesMaquina = new List<String>()
        {
            "Piedra",
            "Papel",
            "Tijera"
   
        };
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 3000;
            timer1.Tick += Timer_Tick;
            tiempoRestante = 3; // Tiempo en segundos
            ActualizarLabel();
            elegirGanador();
        }
        private int random_cal(int min, int max)
        {
            var random = new Random();
            int nuevoRandom = random.Next(min, max);
            return nuevoRandom;

        }
        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
            if (rb_papel.Checked)
            {
                lb_choseJugador.Text = "Papel";
                elegieMaquina();

            }
            else if (rb_piedra.Checked)
            {
                lb_choseJugador.Text = "Piedra";
                elegieMaquina();
            }
            else
            {
                lb_choseJugador.Text = "Tijera";
                elegieMaquina();
            }
           
            elegieMaquina();
            elegirGanador();

        }
        private void elegieMaquina()
        {
            int random = random_cal(0,3);
            lb_eleige_Maquina.Text = opcionesMaquina[random].ToString();
    

        }

        private void elegirGanador()
        {
            if(lb_eleige_Maquina.Text == "Tijera"){

                if(lb_choseJugador.Text == "Tijera")
                {
                    lb_resultadoText.Text = "Empate, todos perdemos";
                 

                }else if (lb_choseJugador.Text == "Papel"){

                    lb_resultadoText.Text = "Ha ganado la máquina, sayonara baby";
                    vecesGanadasMaquina += 1;
                }
                else
                {
                    lb_resultadoText.Text = "Felicidades, has ganado!";
                    vecesGanadasJugador += 1;
                }
       
            }
            else if(lb_eleige_Maquina.Text == "Papel")
            {
                if (lb_choseJugador.Text == "Tijera")
                {
                    lb_resultadoText.Text = "Felicidades, has ganado!";
                    vecesGanadasMaquina += 1;

                }
                else if (lb_choseJugador.Text == "Papel")
                {
                    lb_resultadoText.Text = "Empate, todos perdemos";
                   
                }
                else
                {
                    lb_resultadoText.Text = "Felicidades, has ganado!";
                    vecesGanadasJugador += 1;
                }

            }
            else if(lb_eleige_Maquina.Text == "Piedra")
            {
                if (lb_choseJugador.Text == "Tijera")
                {
                    lb_resultadoText.Text = "Ha ganado la máquina, sayonara baby";
                    vecesGanadasMaquina += 1;
                    

                }
                else if (lb_choseJugador.Text == "Papel")
                
                {
                    lb_resultadoText.Text = "Felicidades, has ganado!";
                    vecesGanadasJugador += 1;

                }
                else
                {
                    lb_resultadoText.Text = "Empate, todos perdemos";

                }
            }

            tiempoRestante = 3;
            ActualizarLabel();
            CalcularMediaAciertos();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
        
            tiempoRestante--;

            ActualizarLabel();

            if (tiempoRestante <= 0)
            {

                timer1.Stop();
                lb_choseJugador.Text = null;
                lb_eleige_Maquina.Text = null;
            }
     
        }
        private void CalcularMediaAciertos()
        {
            int totalRondas = vecesGanadasJugador + vecesGanadasMaquina;
            double mediaAciertos = totalRondas > 0 ? (double)vecesGanadasJugador / totalRondas : 0.0;
            mediaAciertos = Math.Round(mediaAciertos, 2);
            labelJugador.Text =  "Jugador (" + mediaAciertos + ")";
        }

        private void ActualizarLabel()
        {
           
            lblTiempoRestante.Text = $"Siguiente ronda en: {tiempoRestante} segundos";
        }
    }
}
