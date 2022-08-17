namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Button btn_ligaDesliga;
        private Label label1;
        private Label lbl_estado;
        private Label lbl_carga;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Button btn_trocaBateria;
    }
}