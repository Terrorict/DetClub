
namespace DetClub
{
    partial class MenuForm
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
            this.btReports = new System.Windows.Forms.Button();
            this.btManagers = new System.Windows.Forms.Button();
            this.btAccountants = new System.Windows.Forms.Button();
            this.btCashiers = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btPasswordWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btReports
            // 
            this.btReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btReports.Location = new System.Drawing.Point(38, 12);
            this.btReports.Name = "btReports";
            this.btReports.Size = new System.Drawing.Size(262, 59);
            this.btReports.TabIndex = 0;
            this.btReports.Text = "Учёт клиентов (не работает)";
            this.btReports.UseVisualStyleBackColor = true;
            // 
            // btManagers
            // 
            this.btManagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btManagers.Location = new System.Drawing.Point(38, 77);
            this.btManagers.Name = "btManagers";
            this.btManagers.Size = new System.Drawing.Size(262, 59);
            this.btManagers.TabIndex = 1;
            this.btManagers.Text = "Руководители";
            this.btManagers.UseVisualStyleBackColor = true;
            // 
            // btAccountants
            // 
            this.btAccountants.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAccountants.Location = new System.Drawing.Point(38, 142);
            this.btAccountants.Name = "btAccountants";
            this.btAccountants.Size = new System.Drawing.Size(262, 59);
            this.btAccountants.TabIndex = 2;
            this.btAccountants.Text = "Бухгалтера";
            this.btAccountants.UseVisualStyleBackColor = true;
            // 
            // btCashiers
            // 
            this.btCashiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCashiers.Location = new System.Drawing.Point(38, 207);
            this.btCashiers.Name = "btCashiers";
            this.btCashiers.Size = new System.Drawing.Size(262, 59);
            this.btCashiers.TabIndex = 2;
            this.btCashiers.Text = "Кассиры";
            this.btCashiers.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(38, 337);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(262, 59);
            this.button5.TabIndex = 2;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btPasswordWrite
            // 
            this.btPasswordWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btPasswordWrite.Location = new System.Drawing.Point(38, 272);
            this.btPasswordWrite.Name = "btPasswordWrite";
            this.btPasswordWrite.Size = new System.Drawing.Size(262, 59);
            this.btPasswordWrite.TabIndex = 2;
            this.btPasswordWrite.Text = "Изменить пароль";
            this.btPasswordWrite.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 407);
            this.Controls.Add(this.btPasswordWrite);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btCashiers);
            this.Controls.Add(this.btAccountants);
            this.Controls.Add(this.btManagers);
            this.Controls.Add(this.btReports);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btReports;
        private System.Windows.Forms.Button btManagers;
        private System.Windows.Forms.Button btAccountants;
        private System.Windows.Forms.Button btCashiers;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btPasswordWrite;
    }
}