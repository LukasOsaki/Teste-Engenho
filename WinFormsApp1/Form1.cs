namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            iniciar();
        }



        Classes.Lanterna lanterna = new Classes.Lanterna();
        Classes.Bateria bateria = new Classes.Bateria();
        private void iniciar()
        {
            this.lanterna.Estado = "Ligado";
            this.bateria.Carga = 100;
            lbl_estado.Text = lanterna.Estado;
            lbl_carga.Text = bateria.Carga.ToString();
            progressBar1.Value = bateria.Carga;
           if(lanterna.Estado == "Ligado") { 
                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += new EventHandler(count_down);
                timer1.Interval = 1000;
                timer1.Start();
            }
        }

        private void count_down(object sender, EventArgs e)
        {
            
            if (this.bateria.Carga == 0)
            {
                timer1.Stop();
                lanterna.Estado = "Desligado";
                lbl_estado.Text = lanterna.Estado;
            }
            else if (this.bateria.Carga > 0)
            {
                this.bateria.Carga--;
                progressBar1.Value = this.bateria.Carga;
                lbl_carga.Text = this.bateria.Carga.ToString();
            }
        }

        private void btn_ligaDesliga_Click(object sender, EventArgs e)
        {
            if(lanterna.Estado == "Desligado")
            {
                lanterna.Estado = "Ligado";
                lbl_estado.Text = lanterna.Estado;
                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += new EventHandler(count_down);
                timer1.Interval = 1000;
                timer1.Start();
            } else
            {
                timer1.Stop();
                lanterna.Estado = "Desligado";
                lbl_estado.Text = lanterna.Estado;
            }
            
        }

        private void btn_trocaBateria_Click(object sender, EventArgs e)
        {
            this.bateria.Carga = 100;
            progressBar1.Value = this.bateria.Carga;
            lbl_carga.Text = this.bateria.Carga.ToString();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_ligaDesliga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_carga = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_trocaBateria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ligaDesliga
            // 
            this.btn_ligaDesliga.Location = new System.Drawing.Point(80, 131);
            this.btn_ligaDesliga.Name = "btn_ligaDesliga";
            this.btn_ligaDesliga.Size = new System.Drawing.Size(144, 23);
            this.btn_ligaDesliga.TabIndex = 0;
            this.btn_ligaDesliga.Text = "Liga/Desliga";
            this.btn_ligaDesliga.UseVisualStyleBackColor = true;
            this.btn_ligaDesliga.Click += new System.EventHandler(this.btn_ligaDesliga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estado";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(186, 30);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(38, 15);
            this.lbl_estado.TabIndex = 2;
            this.lbl_estado.Text = "label2";
            // 
            // lbl_carga
            // 
            this.lbl_carga.AutoSize = true;
            this.lbl_carga.Location = new System.Drawing.Point(186, 94);
            this.lbl_carga.Name = "lbl_carga";
            this.lbl_carga.Size = new System.Drawing.Size(38, 15);
            this.lbl_carga.TabIndex = 3;
            this.lbl_carga.Text = "label3";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(80, 86);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // btn_trocaBateria
            // 
            this.btn_trocaBateria.Location = new System.Drawing.Point(80, 169);
            this.btn_trocaBateria.Name = "btn_trocaBateria";
            this.btn_trocaBateria.Size = new System.Drawing.Size(144, 23);
            this.btn_trocaBateria.TabIndex = 5;
            this.btn_trocaBateria.Text = "Trocar Bateria";
            this.btn_trocaBateria.UseVisualStyleBackColor = true;
            this.btn_trocaBateria.Click += new System.EventHandler(this.btn_trocaBateria_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_trocaBateria);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_carga);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ligaDesliga);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}