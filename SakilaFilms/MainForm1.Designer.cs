namespace SakilaFilms
{
    partial class MainForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.filmsListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(12, 53);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(214, 21);
            this.categoryComboBox.TabIndex = 0;
            // 
            // filmsListView
            // 
            this.filmsListView.HideSelection = false;
            this.filmsListView.Location = new System.Drawing.Point(12, 80);
            this.filmsListView.Name = "filmsListView";
            this.filmsListView.Size = new System.Drawing.Size(434, 399);
            this.filmsListView.TabIndex = 1;
            this.filmsListView.UseCompatibleStateImageBehavior = false;
            this.filmsListView.View = System.Windows.Forms.View.List;
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.filmsListView);
            this.Controls.Add(this.categoryComboBox);
            this.Name = "MainForm1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ListView filmsListView;
    }
}

